<h2>Introduction</h2>
The project is a smart API developed using ASP.NET Core 3.1 and MongoDb
<br>
The API creates databases per websites where the requests come from and creates tables for the respective databases.

<h2>Requirements</h2>
ASP.NET Core 3.1 <br>
Mongo Db Server
<h4>Packages<h4>
<p>
1. AutoMapper.Extensions.Microsoft.DependencyInjection <br>
2. Microsoft.AspNetCore.Cors <br>
3. MongoDB.Driver<br>
  </p>

  
  <h2>How to run</h2>
  <ol>
    <li>Build the project</li>
    <li>Right click on Solution Explorer and set startup projects to both "SparkPlug" and "SparkPlug.Web"</li>
    <li>Install the following packages if not properly installed by the project build - AutoMapper.Extensions.Microsoft.DependencyInjection, Microsoft.AspNetCore.Cors, MongoDB.Driver
    <li>Start project</li>
    <li>Start mongo db server.  <br>
      follow the link https://www.mongodb.com/docs/manual/tutorial/manage-mongodb-processes/ on how to start a mongo db server
    </li>
  </ol>
  
  The solution starts with two projects loaded. The Web project containing the HTML, CSS and Javascript, and also the API project that receives request.
