namespace TesteAPI.Entities
{
    public class Request
    {
        public int take { get; set; }
        public int pageSize { get; set; }
        public int skip { get; set; }
        public int page { get; set; }
        public bool export { get; set; }
        public List<Sort> sort { get; set; }

        //Custom
        public string search { get; set; }
        public List<CustomParameter> parms { get; set; }
    }
    public class CustomParameter
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class Sort
    {
        public string field { get; set; }
        public string dir { get; set; }
    }
}
