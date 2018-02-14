
# FantaCode Internship
# WEEK 12:Report 

###### Date: 14/02/2018
### Tasks 

The resource for this week is here:<br>
<b>Dependency Injection (DI)</b>
* https://developer.xamarin.com/guides/xamarin-forms/enterprise-application-patterns/dependency-injection/
* https://xamarinhelp.com/xamarin-forms-dependency-injection/
* https://www.youtube.com/watch?v=YZKaNsIQp8o
* This article will introduce you to a library and different frameworks that can be used for coding in MVVM Pattern.
https://xamgirl.com/prism-in-xamarin-forms-step-by-step-part-1/


<b>Task</b> : Create an application using Prism and implementing DI.
### Tasks done:

* Read the documentation given above on Dependency Injection. Watched the video tutorial of Houssem Dellai using Prism. The blog by xamgirl was pretty easy and could understand better.
* To get a better idea, I went forward to refer other sources and found the below quite useful:<br>

  <b>Prism for Xamarin Forms<b>
   <br>https://dzone.com/articles/prism-for-xamarin-forms-an-overview-part-1
<br>https://dzone.com/articles/prism-for-xamarin-forms-part-2-basic-navigation-an
<br>https://dzone.com/articles/prism-for-xamarin-forms-part-3-advanced-navigation?fromrel=true<br>
  
  <b>Implementing NavigationService for Xamarin Forms and MVVM ( by Houssem Dellai )<b>
  <br>https://channel9.msdn.com/Blogs/MVP-Windows-Dev/Implementing-NavigationService-for-Xamarin-Forms-and-MVVM
  
  <b>The Xamarin Show: Prism for Xamarin.Forms with Brian Lagunas and James Montemagno<b>
  <br>https://channel9.msdn.com/Shows/XamarinShow/Prism-for-XamarinForms-with-Brian-Lagunas
* Points noted:<br>
  - Prism is a framework which embraces best coding practices to develop loosely coupled, maintainable, and testable applications.
    It basically allows us to use MVVM technique more comfortably. It also allows us to deal with navigation, passing parameters and         commands easily which can often get complex using the MVVM technique without any framework.
  - Dependency Injection : This is used to create loosely coupled dependencies. Here dependencies involve those between views,services       and viewmodels. This architecture also enables one to access platform specific code for Android or iOS from a shared PCL project.
    It’s common to use DI container frameworks to simplify object creation. These frameworks are available as nuget packages like             Ninject, Autofac, TinyIoc, StructureMap. Here I have used Unity in my application.
* Steps followed:<br>
  I followed the steps as given in https://xamgirl.com/prism-in-xamarin-forms-step-by-step-part-1/
1. Installed the Prism package : Prism.Unity.Forms <img src="https://camo.githubusercontent.com/d058cbbfae2bb63cd7e46efd0e6edb49c160cfda/68747470733a2f2f696d672e736869656c64732e696f2f6e756765742f762f58616d2e506c7567696e2e4d656469612e7376673f6c6162656c3d4e75476574" alt="NuGet" data-canonical-src="https://img.shields.io/nuget/v/Xam.Plugin.Media.svg?label=NuGet" style="max-width:100%;">
1. 


  

