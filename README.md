<h2>Introduction</h2>
The Application helps Spark plug web design agencies to satisfy their customers better. To optimize and serve their customers better, a new feature is required. The featuer requires a smart API that automatically creates databases per websites, create tables per form and inserts data to respective tables when the forms consume the APIs

<h2>Requirements</h2>
- The application targets ASP.NET Core 3.1 - Download and Install ASP.NET Core 3.1 SDK and ASP.NET Core 3.1 Runtime if not available on your machine. Both packages can be found here https://dotnet.microsoft.com/en-us/download/dotnet/3.1 <br>
- MongoDb Server - You can download and install MongoDb Server here https://docs.mongodb.com/manual/administration/install-community/
<h4>Packages</h4>
<ol>
<li>AutoMapper.Extensions.Microsoft.DependencyInjection </li>
<li>Microsoft.AspNetCore.Cors </li>
<li>MongoDB.Driver</li>
</ol>

  
  <h2>How to run</h2>
  <ol>
    <li>Build the solution</li>
    <li>Install the following packages if not properly installed by the project build - AutoMapper.Extensions.Microsoft.DependencyInjection, Microsoft.AspNetCore.Cors, MongoDB.Driver</li>
    <li>Right click on Solution (SparkPlug) and set startup projects to both "SparkPlug" and "SparkPlug.Web"</li>
    <li>Start the projects by clicking on Start </li>
    <li>Start mongo db server.  <br>
      follow the link https://www.mongodb.com/docs/manual/tutorial/manage-mongodb-processes/ on how to start a mongo db server
    </li>
  </ol>
  
  The solution starts with the two projects (SparkPlug and SparkPlug.Web) loaded. The Web project containing the HTML, CSS and Javascript. While the API project receives request.
  
  
  ## SAMPLE REQUEST

``` POST - https://localhost:44387/api/feedback ```

``` javascript
{ 
    "CustomerName" : "Bakare Israel",
    "CustomerEmail" : "bakare@gmail.com",
    "CustomerMessage" : "I enjoyed the service I received the last time I patronized your business",
    "DomainName" : "Solado",
    "FormName" : "Form2"
}
```
  ```Response: Successful```
  
  ## WHAT TO TEST
  After successfully starting both api and web projects. Fill the form appropriately and click on the "Send Feedback" button to submit. The inputs in the form is sent to the api which saves the data appropriately and sends a feedback message.
