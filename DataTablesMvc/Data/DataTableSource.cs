namespace DataTablesMvc
{
    public class DataTableSource : IDataTableSource
    {
        public DataTableSource()
        {
            Request = DataTableRequest.Empty;
            Response = DataTableResponse.Empty;
        }

        public DataTableRequest Request { get; set; }
        public DataTableResponse Response { get; set; }
    }

    public interface IDataTableSource
    {
        DataTableRequest Request { get; set; }
        DataTableResponse Response { get; set; }
    }
}
