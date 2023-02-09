using System.Text;
using System.Threading.Channels;

namespace WebScraping
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string html = await new HttpClient().GetStringAsync("http://unify1.gx.cmcc:10020/employeePerf/perfFeedBackAction.do?method=showToRead&activityid=1675769375059&mainAssessId=2946105&showBtn=true&feeback_kind=03%22");
            Console.WriteLine(html);
        }
    }
}