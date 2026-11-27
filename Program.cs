using System;
using System.IO;
using System.Text;



string[] names = { "Lilith Nakamura", "Julia Daniels" , "Hallon Plaintiffin" , "Aria Weber" , "Jennifer Miller" , "Kazuki Chiu" , "Deniz Richards" , "Jessalyn Byrne" , "Astrid Aberg" , "Anita Silva"};  
string[] overview = 
    {
"https://chief-split-0d9.notion.site/Lilith-Overview-4096a2c25cab809f90f0fc38ec0040d0?pvs=143" ,
"https://chief-split-0d9.notion.site/Julia-Overview-4136a2c25cab80a9bcedd23fdbc81e51" ,
"https://chief-split-0d9.notion.site/Hallon-Overview-41c6a2c25cab80d49d25cc88ff86c6bb" ,
"https://chief-split-0d9.notion.site/Aria-Overview-4256a2c25cab808e9277e40f5479d701" ,
"https://chief-split-0d9.notion.site/Jennifer-Overview-4256a2c25cab803e8166df2c2e2742b0" ,
"https://chief-split-0d9.notion.site/Kazuki-Overview-4256a2c25cab80aaab33c92aaa2f2661" ,
"https://chief-split-0d9.notion.site/Deniz-Overview-4256a2c25cab80bca50cf58435f6248c" ,
"https://chief-split-0d9.notion.site/Jessalyn-Overview-4256a2c25cab8018a917defc78c69ea8" ,
"https://chief-split-0d9.notion.site/Astrid-Overview-4256a2c25cab80c6aa3dfe0bf4e57df9" ,
"https://chief-split-0d9.notion.site/Anita-Overview-4256a2c25cab80b3a5a1f7b68d81d5a5"
      };

string[] Sypnosis = 
    {
"https://chief-split-0d9.notion.site/Lilith-Synopsis-4136a2c25cab80fba8e3ff527b896a7c?pvs=143",
"https://chief-split-0d9.notion.site/Julia-Synopsis-4136a2c25cab80498cf2ff506e326439" ,
"https://chief-split-0d9.notion.site/Hallon-Synopsis-41c6a2c25cab803084a6c76bfdde614d" ,
"https://chief-split-0d9.notion.site/Aria-Synopsis-4256a2c25cab80e4936dee7ac796dff7" ,
"https://chief-split-0d9.notion.site/Jennifer-Synopsis-4256a2c25cab80c8a449c94a1542f232" ,
"https://chief-split-0d9.notion.site/Kazuki-Synopsis-4256a2c25cab806488b9fb2c1865e5fc" ,
"https://chief-split-0d9.notion.site/Deniz-Synopsis-4256a2c25cab8069b55ef0be543dc5a0" ,
"https://chief-split-0d9.notion.site/Jessalyn-Synopsis-4256a2c25cab80a9a8b1f6b4c8ae3212" ,
"https://chief-split-0d9.notion.site/Astrid-Synopsis-4256a2c25cab80f1aa15d785d324ebf6" ,
"https://chief-split-0d9.notion.site/Anita-Synopsis-4256a2c25cab803db690e18d28cca496"
 };

string[] relationships =
{
    "https://chief-split-0d9.notion.site/Lilith-Relationships-4136a2c25cab800db194e58c03f239d4" ,
    "https://chief-split-0d9.notion.site/Julia-Relationship-4136a2c25cab80549b8ad16604c62a75" ,
    "https://chief-split-0d9.notion.site/Hallon-Relationships-41c6a2c25cab80d5bd17c4c2f95daef4" ,
    "https://chief-split-0d9.notion.site/Aria-Relationships-4256a2c25cab809eb984f25fcc208b86" ,
    "https://chief-split-0d9.notion.site/Jennifer-Relationships-4256a2c25cab805e8f47d773a258ea04" ,
    "https://chief-split-0d9.notion.site/Kazuki-Relationships-4256a2c25cab8025b9f5ffc9edb2a866" ,
    "https://chief-split-0d9.notion.site/Deniz-Relationships-4256a2c25cab8075bce8eceb6c7ae3bd" ,
    "https://chief-split-0d9.notion.site/Jessalyn-Relationships-4256a2c25cab80659445eb2b016780a0" ,
    "https://chief-split-0d9.notion.site/Astrid-Relationships-4256a2c25cab80a7bd04f3ffdbc518e8" ,
    "https://chief-split-0d9.notion.site/Anita-Relationships-4256a2c25cab8023b2c6cdca92d10666"
};

StringBuilder HTML = new StringBuilder();

HTML.AppendLine("<!DOCTYPE html>");
HTML.AppendLine("<html>");
HTML.AppendLine("<head>");
HTML.AppendLine("<meta charset= \"UTF-8\">");
HTML.AppendLine("<titel>Character Archive</title>");

HTML.AppendLine("<style>");

HTML.AppendLine("* {box-sizing: border-box;}");

HTML.AppendLine("body {");
HTML.AppendLine("margin: 0;");
HTML.AppendLine("padding: 40px,");
HTML.AppendLine("font-family: 'Segoe UI', Arial, sans-serif;");
HTML.AppendLine("background: #ffe5ee;");
HTML.AppendLine("color: #743d5b;");
HTML.AppendLine("min-height: 100vh;");
HTML.AppendLine("}");

HTML.AppendLine("</head>");
HTML.AppendLine("<body>");

for (int i = 0; i < names.Length; i++)
{
    HTML.AppendLine("<h2>" + names[i] + "</h2>");
    HTML.AppendLine("<div class=\"tabs\">");

    HTML.AppendLine("<button onclick=\"showPage('" + overview[i] + "')\"> Overview</button>");

    HTML.AppendLine("<button onclick=\"showPage('" + Sypnosis[i] + "') \">Sypnosis</button>");

    HTML.AppendLine("<button onclick=\"showPage('" + relationships[i] + "')\">Relationships</button>");

    HTML.AppendLine("</div>");

    
}
HTML.AppendLine("<script>");
HTML.AppendLine("function showPage(url) {");
HTML.AppendLine("window.open(url, 'NotionPage', 'width=900, height=700');");
HTML.AppendLine("}");
HTML.AppendLine("</script>");

HTML.AppendLine("</body>");
HTML.AppendLine("</html>");

File.WriteAllText("../../../index.html", HTML.ToString());