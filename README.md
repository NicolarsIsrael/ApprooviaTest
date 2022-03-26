<h2>Introduction</h2>
The Application helps Spark plug web design agencies to satisfy their customers better. To optimize and serve their customers better, a new feature is required. The featuer requires a smart API that automatically creates databases per websites, create tables per form and inserts data to respective tables when the forms consume the APIs

<h2>Requirements</h2>
ASP.NET Core 3.1 - Install ASP.NET Core 3.1 SDK if not available on machine https://dotnet.microsoft.com/en-us/download/dotnet/3.1 <br>
Mongo Db Server
<h4>Packages<h4>
<p>
1. AutoMapper.Extensions.Microsoft.DependencyInjection <br>
2. Microsoft.AspNetCore.Cors <br>
3. MongoDB.Driver<br>
  </p>

  
  <h2>How to run</h2>
  <ol>
    <li>Build the solution</li>
    <li>Right click on Solution Explorer and set startup projects to both "SparkPlug" and "SparkPlug.Web"</li>
    <li>Install the following packages if not properly installed by the project build - AutoMapper.Extensions.Microsoft.DependencyInjection, Microsoft.AspNetCore.Cors, MongoDB.Driver
    <li>Start project</li>
    <li>Start mongo db server.  <br>
      follow the link https://www.mongodb.com/docs/manual/tutorial/manage-mongodb-processes/ on how to start a mongo db server
    </li>
  </ol>
  
  The solution starts with two projects loaded. The Web project containing the HTML, CSS and Javascript, and also the API project that receives request.
  <h2>Sample Request</h2>
  api route: /api/feedback
  <br> Method: POST
  <br>
  body : { <br>
    "CustomerName":"Bakare Israel", <br>
    "CustomerEmail":"bakare@gmail.com", <br>
    "CustomerMessage":"I enjoyed the service I received the last time I patronized your business", <br>
    "DomainName":"Solado", <br>
    "FormName":"Form2" <br>
}
