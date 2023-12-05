using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using PackageTracker.Models;
using System.IO.Packaging;

namespace PackageTracker._Repositories
{
    public class PackageRepository : BaseRepository, IPackageRepository
    {
        //Constructor
        public PackageRepository(string _connectionString)
        {
            this.connectionString = _connectionString;
        }

        // Methods
        public void Add(PackageModel packageModel)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"insert into PackageInfo (Sender,Receiver,Status,Weight,WeightUnits) 
                                        VALUES (@sender,@receiver,@status,@weight,@units)";
                command.Parameters.Add("@sender", MySqlDbType.TinyText).Value = packageModel.Sender;
                command.Parameters.Add("@receiver", MySqlDbType.TinyText).Value = packageModel.Receiver;
                command.Parameters.Add("@status", MySqlDbType.Enum).Value = packageModel.Status;
                command.Parameters.Add("@weight", MySqlDbType.Decimal).Value = packageModel.Weight;
                command.Parameters.Add("@units", MySqlDbType.VarChar).Value = packageModel.WeightUnits;
                command.ExecuteNonQuery();
            }
        }
        public void AddWithDelivery(PackageModel packageModel)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"insert into PackageInfo (Sender,Receiver,Status,Weight,DeliveryDate,WeightUnits) 
                                        VALUES (@sender,@receiver,@status,@weight,(STR_TO_DATE(@delivery,'%c/%e/%Y %r')),@units)";
                command.Parameters.Add("@sender", MySqlDbType.TinyText).Value = packageModel.Sender;
                command.Parameters.Add("@receiver", MySqlDbType.TinyText).Value = packageModel.Receiver;
                command.Parameters.Add("@status", MySqlDbType.Enum).Value = packageModel.Status;
                command.Parameters.Add("@weight", MySqlDbType.Decimal).Value = packageModel.Weight;
                command.Parameters.Add("@delivery", MySqlDbType.String).Value = packageModel.DeliveryDate.ToString();
                command.Parameters.Add("@units", MySqlDbType.VarChar).Value = packageModel.WeightUnits;
                command.ExecuteNonQuery();
            }
        }
        public void Delete(int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from PackageInfo where PackageID=@id";
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                command.ExecuteNonQuery();
            }
        }
        public void Edit(PackageModel packageModel)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update PackageInfo 
                                        set Status=@status, 
                                        DeliveryDate=(STR_TO_DATE(@delivery,'%c/%e/%Y %r')) 
                                        where PackageID=@id";
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = packageModel.PackageID;
                command.Parameters.Add("@status", MySqlDbType.Enum).Value = packageModel.Status;
                command.Parameters.Add("@delivery", MySqlDbType.String).Value = packageModel.DeliveryDate.ToString();
                command.ExecuteNonQuery();
            }
        }
        public void UpdateStatus(PackageModel packageModel)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update PackageInfo 
                                        set Status=@status
                                        where PackageID=@id";
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = packageModel.PackageID;
                command.Parameters.Add("@status", MySqlDbType.Enum).Value = packageModel.Status;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<PackageModel> GetAll()
        {
            var packageList = new List<PackageModel>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand()) 
            { 
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from PackageInfo order by PackageID desc";
                using (var reader = command.ExecuteReader()) 
                { 
                    while (reader.Read())
                    {
                        var packageModel = new PackageModel();
                        packageModel.PackageID = (int)reader[0];
                        packageModel.Sender = reader[1].ToString();
                        packageModel.Receiver = reader[2].ToString();
                        packageModel.Status = reader[3].ToString();
                        packageModel.Weight = (decimal)reader[4];
                        if (reader[5] != DBNull.Value)
                        {
                            packageModel.DeliveryDate = (DateTime)reader[5];
                        }
                        packageModel.WeightUnits = reader[6].ToString();
                        if (reader[7] != DBNull.Value)
                        {
                            packageModel.SentDate = (DateTime)reader[7];
                        }
                        if (reader[8] != DBNull.Value)
                        {
                            packageModel.CreatedDate = (DateTime)reader[8];
                        }
                        packageList.Add(packageModel);
                    }
                }
            }
            return packageList;
        }

        public IEnumerable<PackageModel> GetByValue(string value)
        {
            var packageList = new List<PackageModel>();
            int packageID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string likePattern = '%' + value + "%";
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *from PackageInfo 
                                        where PackageID=@id 
                                            OR Sender like @sender 
                                            OR Receiver like @receiver 
                                        order by PackageID desc";
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = packageID;
                command.Parameters.Add("@sender", MySqlDbType.TinyText).Value = likePattern;
                command.Parameters.Add("@receiver", MySqlDbType.TinyText).Value = likePattern;
                
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var packageModel = new PackageModel();
                        packageModel.PackageID = (int)reader[0];
                        packageModel.Sender = reader[1].ToString();
                        packageModel.Receiver = reader[2].ToString();
                        packageModel.Status = reader[3].ToString();
                        packageModel.Weight = (decimal)reader[4];
                        if (reader[5] != DBNull.Value)
                        {
                            packageModel.DeliveryDate = (DateTime)reader[5];
                        }
                        packageModel.WeightUnits = reader[6].ToString();
                        if (reader[7] != DBNull.Value)
                        {
                            packageModel.SentDate = (DateTime)reader[7];
                        }
                        if (reader[8] != DBNull.Value)
                        {
                            packageModel.CreatedDate = (DateTime)reader[8];
                        }
                        packageList.Add(packageModel);
                    }
                }
            }
            return packageList;
        }
    }
}
