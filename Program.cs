namespace AspRequestQueryStringApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Run(async (context) => {
                var request = context.Request;
                var path = request.Path;
                var queryString = request.QueryString;
                var query = request.Query;

                string str = "";
                foreach(var item in query)
                    str += "key: " + item.Key.ToString() + " value: " + item.Value.ToString() + "\n";


                await context.Response.WriteAsync(path + "\n" + queryString + "\n" + str);
            });


            app.Run();
        }
    }
}