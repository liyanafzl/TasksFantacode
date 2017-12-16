# FantaCode Internship
# WEEK 5:Report 

###### Date: 16/12/2017
### Tasks
<b>Xamarin Forms Styles & Introduction to MVVM in Xamarin Forms</b>
1. Xamarin Forms Styles - https://www.youtube.com/watch?list=PLpbcUe4chE7-5t2mlamz6yB0qzAfO5Yln&v=yaC0-C942wk
1. MVVM DataBinding - https://www.youtube.com/watch?list=PLpbcUe4chE7-5t2mlamz6yB0qzAfO5Yln&v=uEn9FlLL5wo
1. MVVM Commands - https://www.youtube.com/watch?list=PLpbcUe4chE7-5t2mlamz6yB0qzAfO5Yln&v=wmOrD7AcdCY
<br> 
Convert the To-Do app created in Week 4 to MVVM pattern. 

 
### Tasks done:
* Styles- Implemented styles in MainPage.xaml
* Learnt about using MVVM concept through videos by Houssem Dellai and Xamarin forums (MVVM is useful when unit testing needs to be done)
	<br>Model - data
	<br>View -  UI
	<br>View model - Logic (should be made public)
	<br>Learnt about using commands in MVVM
* Learnt about navigating from one page to another using MVVM 
* Implemented MVVM concept in the app made in Week 4 (To Do List Application)
* * Models : TaskModel
* * ViewModels : TaskViewModel and ListViewModel
* * Views : MainPage.xaml and ListPageView.xaml
* Uploaded the applications to my git repository :
	https://github.com/liyanafzl/TasksFantacode/tree/master/Week5



### Problem encountered:
* https://forums.xamarin.com/discussion/113218/trouble-while-creating-a-xaml-file-and-not-able-to-compile-project-due-to-that-xaml-file
	<br>Solved: It seems that version 15.5.1 of visual studio 2017 has a lot of issues. 
Solved by updating to version 15.5.2
* Tried using same view model for two views. 
<br> Error : The given key was not present in the dictionary.
<br>It worked after using different view models for each view.
* Exceptions occurred:
<br>When the below line was not included when including navigation from one page to another.
<br>MainPage = new NavigationPage(new MainPage())
* Problems occur when the name using for binding data in view is different from that used in the view model.

