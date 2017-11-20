# FantaCode Internship
# WEEK 2:Report 

###### Date: 18/11/2017
### Tasks
1. Using GitHub for Source Control
1. Using Google to find what you are trying to achieve.
1. Identify major component of a Mobile Application.
 
1. Content Page – https://www.youtube.com/watch?list=PLpbcUe4chE7-5t2mlamz6yB0qzAfO5Yln&v=NP4Gea1j7Ig
1. Label, Buttons and Entries - https://www.youtube.com/watch?list=PLpbcUe4chE7-5t2mlamz6yB0qzAfO5Yln&v=HGFglKxXxVY
1. UI Properties – https://www.youtube.com/watch?list=PLpbcUe4chE7-5t2mlamz6yB0qzAfO5Yln&v=F1SAD-rQ-4o
 
At the end of the week, we are expected to develop a single page Android and iOS application based on Xamarin Forms.
 
 
 
 
### Tasks done:

1. Watched the videos on Content page, label,buttons and entries, UI properties and tried to implement them.
1. Created an application based on the Xamarin forms using Visual Studio 2017.
	 1. ToDo: A single page application to note the tasks as in a ToDo list.
       * Learned how to implement ListView.
   1. Maps: Tried to implement Google maps API. Generated key for using google maps API. The application could not be completed.
   1. MyProfile:  An application to enter profile details.
1. Familiarised with the functions of clone, commit and push using github.
1. Uploaded the applications to my git repository :
https://github.com/liyanafzl/TasksFantacode/tree/master/ToDo
https://github.com/liyanafzl/TasksFantacode/tree/master/MyProfile
https://github.com/liyanafzl/TasksFantacode/tree/master/Maps

### Problems encountered:

1. Visual studio couldn’t identify any device connected via USB and while running the emulator, it showed deployment errors.
	Solution: Reinstalled USB driver for the device ( Lenovo S60). It worked fine.
1. Couldn’t run the application on the emulator.
	Error: Process isn’t responding.
1. xaml - Property Content is null or is not IEnumerable	
Solution: Content cannot hold multiple layouts. It is made sure that Content holds a single StackLayout
1. Using Google maps API 	
Followed a tutorial to generate the key to use Google maps API. Included it in   the AndroidManifest file. Installed NuGet Packages : Xamarin.Forms.Maps. But the application could not resolve the newly installed packages.
1. Implementing listview in xaml and c#.
Learned that listview can be implemented using both xaml and c#.  An element in xaml can be accessed in c# using the Name property. Implemented a simple Listview with elements as string but could not implement customized ListView using DataTemplates.

