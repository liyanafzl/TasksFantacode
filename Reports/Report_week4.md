# FantaCode Internship
# WEEK 4:Report 

###### Date: 09/12/2017
### Tasks
1. List View - https://www.youtube.com/watch?list=PLpbcUe4chE7-5t2mlamz6yB0qzAfO5Yln&v=xqF4G2kGFHI
1. List View Item Template - https://www.youtube.com/watch?list=PLpbcUe4chE7-5t2mlamz6yB0qzAfO5Yln&v=xqF4G2kGFHI
1. ListView Styling - https://www.youtube.com/watch?list=PLpbcUe4chE7-5t2mlamz6yB0qzAfO5Yln&v=N0e3fPisIw8
<br>At the end of this week, we are expected to develop a multi-page application with ListView and a detailed page. Preferably a simple To-Do app without any storage.
 
 
### Tasks done:
1. Watched the videos provided to get an idea about using list view and assigning data templates.
1. Created a To-Do Application with no storage.
1. Uploaded the applications to my git repository :
https://github.com/liyanafzl/TasksFantacode/tree/master/App_week4


### Problem encountered:
* Exception occurred : Object reference not set to an instance of an object.
	<br>Occurs when the list is not initialized properly. It might be pointing to a null reference.
* Exception occurred when using NavigationPage.
	<br>It happens when the below line is not included:
	MainPage = new NavigationPage( new App_week4.MainPage());
	<br>[Here I was trying to navigate from MainPage to another page ListPage]
* Exceptions can occur when the DataTemplate,Grid,ViewCell,ItemTemplate in the xaml page are not used as per the requirements.
