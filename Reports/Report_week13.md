# FantaCode Internship
# WEEK 13:Report 
# Module 14 :Unit Test in Xamarin forms

###### Date: 18/02/2018
### Tasks 

The resource for this week is here:<br>

1. Unit Testing - https://www.youtube.com/watch?list=PLpbcUe4chE79VBVHr5qIi4T_rWa1esCqw&v=lp90llE_9-s
2. UI Testing - https://www.youtube.com/watch?list=PLpbcUe4chE79VBVHr5qIi4T_rWa1esCqw&v=hRexS3bbbsE

### Tasks done

* Watched the video tutorials of Houssem Dellai. Understood the importance of using MVVM pattern in Unit testing.
* Created an application as in the video and tried unit testing.
   - Created a Xamarin Forms project .
   - Added the View Models folder and set the binding context to the corresponding views.
   - Created another folder for unit tests and added a new project( Right click Solutions folder - Add new Project - Visual C# -Test -   Unit     Test Project - named it UnitTestProject)
    - Defined the UnitTest class and its unit test methods.
    - Tested the application successfully.
* Uploaded the application in github:<br>
  https://github.com/liyanafzl/TasksFantacode/tree/master/Task13/Module14
  
### Problems encountered

* After following the same steps as given in the video, I was unable to unit test the project. It always showed an exception:<br>
  <b>Message: Test method UnitTestApp.UnitTest.MathUnitTest.AddTest threw exception: 
  System.IO.FileNotFoundException: Could not load file or assembly 'Xamarin.Forms.Core, Version=2.0.0.0, Culture=neutral,       PublicKeyToken=null' or one of its dependencies. The system cannot find the file specified.</b>
  <br> Solution:
  I tried to build, clean and rebuild the projects but was to no avail. Then I installed the nuget package Xamarin.Forms for the particular unit test project (the same version that was installed for the .Net Shared Project ). Re-built the project and when I ran the unit tests, it worked perfectly well.
  




