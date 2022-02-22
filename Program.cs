var connectionString = "localhost:6379";

var cache = RedisConnectorHelper.Connection.GetDatabase();

for (int i = 1; i <= 10; i++)
    await cache.StringSetAsync($"200:STATUS_CODE:{i}:ACTION", "called");

var server = RedisConnectorHelper.Connection.GetServer(connectionString);

foreach (var key in server.Keys(pattern: "*:STATUS_CODE:*"))
    Console.WriteLine(key);