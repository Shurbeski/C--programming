/*
HttpClient class provides a base class for sending/receiving the HTTP requests/responses from a URL. It is a supported async feature of .NET framework. 
HttpClient is able to process multiple concurrent requests. It is a layer over HttpWebRequest and HttpWebResponse. All methods with HttpClient are asynchronous.
*/

// Example 
// To call Web API methods from the console Application, the first step is to install the required packages, using NuGet Package Manager. 
// The following package needs to be installed in the console Application.

// Install-Package Microsoft.AspNet.WebApi.Client

using(var client = newHttpClient())
{
    client.BaseAddress = newUri("http://localhost:55587/");
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(newMediaTypeWithQualityHeaderValue("application/json"));
    //GET Method
    HttpResponseMessage response = awaitclient.GetAsync("api/Department/1");
    if (response.IsSuccessStatusCode)
    {
        Departmentdepartment = awaitresponse.Content.ReadAsAsync < Department > ();
        Console.WriteLine("Id:{0}\tName:{1}", department.DepartmentId, department.DepartmentName);
        Console.WriteLine("No of Employee in Department: {0}", department.Employees.Count);
    }
    else
    {
        Console.WriteLine("Internal server Error");
    }

    var department = newDepartment() { DepartmentName = "Test Department" };
    HttpResponseMessage response = awaitclient.PostAsJsonAsync("api/Department", department);

    if (response.IsSuccessStatusCode)
    {
    // Get the URI of the created resource.
    UrireturnUrl = response.Headers.Location;
    Console.WriteLine(returnUrl);
    }

    //PUT Method
    var department = newDepartment() { DepartmentId = 9, DepartmentName = "Updated Department" };
    HttpResponseMessage response = awaitclient.PutAsJsonAsync("api/Department", department);
    if (response.IsSuccessStatusCode)
    {
    Console.WriteLine("Success");
    }

    intdepartmentId = 9;
    HttpResponseMessage response = awaitclient.DeleteAsync("api/Department/" + departmentId);
    if (response.IsSuccessStatusCode)
    {
    Console.WriteLine("Success");
    }
}

/*
HttpClient is used to send an HTTP request, using a URL. HttpClient can be used to make Web API requests from the console Application, Winform Application,
Web form Application, Windows store Application, etc.
*/
