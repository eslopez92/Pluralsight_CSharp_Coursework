using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();
            doc.Text = "Document text goes here";

            var blogPoster = new BlogPoster();
            var blogDelegate = new Document.SendDoc(blogPoster.PostToBlog);
            doc.ReportSendingResult(blogDelegate);

            var emailsender = new EmailSender();
            var emaildelegate = new Document.SendDoc(emailsender.SendEmail);//emaildelegate = 0
            doc.ReportSendingResult(emaildelegate);
        }
    }
}
