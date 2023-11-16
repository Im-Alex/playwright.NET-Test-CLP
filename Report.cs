

namespace framework
{
    public  class Report
    {

        [Test,Property("Value 1","Value 2")]
        [Author("Alejandro Velazquez Valenzuela", "alejandrovelazquezvalenzuela@gmail.com")]
        [Category("TES-44")]
        [Description("This is a description")]

        public void ReportClassExample1()
        {
            Console.WriteLine("Example Report 1");
        }
    }
}
