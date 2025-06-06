static SQLiteConnection CreateConnection()
{
    SQLiteConnection connection = new SQLiteConnection("Dataa source=myddb.db; Version = 3; New = True; Compress = True;");

    try
    {
        connection.Open();
        Console.WriteLine("DB found.");
    }
    catch
    {
        Console.WriteLine("DB not found.");
    }

    connection.Close();
}