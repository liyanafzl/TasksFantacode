

# FantaCode Internship
# WEEK 10:Report 

###### Date: 27/01/2018
### Tasks 
The task for this week is here:<br>
 
The task for the next week is here:<br>
1. Connecting to Web Services - https://www.youtube.com/watch?list=PLpbcUe4chE7-uGCH1S0-qeuCWOMa2Tmam&v=Lir75oNAeiM
1. Connecting to Web Services
   1. POST - https://www.youtube.com/watch?list=PLpbcUe4chE7-uGCH1S0-qeuCWOMa2Tmam&v=MPm5aY503pU
   1. PUT, DELETE - https://www.youtube.com/watch?list=PLpbcUe4chE7-uGCH1S0-qeuCWOMa2Tmam&v=9DabKzNq6FI
   1. SEARCH - https://www.youtube.com/watch?list=PLpbcUe4chE7-uGCH1S0-qeuCWOMa2Tmam&v=SyWRGJmrlVs
 
### Tasks done:

* MVVM Basic Example:<br>
	Created a sample project that uses the MVVM concept. Created folders: Models, ViewModels, Views and Services. Added the following classes in the respective folders:
  * Model- Employee
  * ViewModels- MainViewModel
  * View- MainPage
  * Services- EmployeeServices
* Connecting Web Services:
*	Learned a few things:
  * Web services are used when applications require external storage using sql database, SQLite or Oracle database etc.
  * An applications consists of mainly 3 components: Mobile application, Web Services, database. Mobile communicates with the Web services using HTTP requests( for this we have to install the HttpClient plugin).Web Services communicate with database using the Entity Framework.(http://www.entityframeworktutorial.net/what-is-entityframework.aspx)
  * Web services in Xamarin Forms are implemented using Web APIs.
	*	How to create one?
<br>Right click solution- Add new Project - Web - ASP.Net Web Application-Set it as StartupProject and run it using a suitable browser
To create the database, SQL queries can be used but ASP.Net with Visual studio provides easier method using controllers.
  * How to create Controller?
		<br>Create a model with the required members(Make sure to keep a primary key). Then create a new Controller in the Controllers folder(which comes automatically with ASP.Net Web Application Project). Here we select Web API 2 Controller with actions. Add the appropriate model name and create a new DataContext. Added another Controller , this time - Web API Controller with Views ( an error occurred while creating this but got it resolved by rebuilding the project)
For each method defined in the Controller, the views are defined under the same name as the method.
  * Installed Plugin.RestClient nuget package( which also installs Newtonsoft.Json and System.Net.Http nuget packages)
  * RestClient Folder contains two Files : RestClient and TaskModel. Most of the code comes by default. We need to just make changes that are necessary. Modify RestClient - i.e., Change the url
Use the RestClient in EmployeeServices
  * Tested the Web API using Web browser and in the mobile application.
<br>Uploaded the application :
	https://github.com/liyanafzl/TasksFantacode/tree/master/Task10/Week11
  
  ### Point to be noted:
  
  * When specifying the base url in Web API, make sure it ends with a "/"
  <br> Example : http://localhost:54631/api/Employees/
  
  * We know that '"await" needs to be used with async methods. When an async method need to be used inside a constructor it can be done as follows because constructors cannot be made async.
   ```
   public MainViewModel()
        {
            InitializeDataAsync();
        }
        public async Task InitializeDataAsync()
        {
            var employeeServices = new EmployeeServices();
            EmployeesList = await employeeServices.GetEmployeesAsync();
        }```

  

