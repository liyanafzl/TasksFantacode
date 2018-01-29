

# FantaCode Internship
# WEEK 9:Report 

###### Date: 20/01/2018
### Tasks 
The task for this week is here:<br>
 
1. Search Bar -  https://www.youtube.com/watch?list=PLpbcUe4chE7-5t2mlamz6yB0qzAfO5Yln&v=hAmcxAmbLcA
1. ListView Header Template - https://www.youtube.com/watch?list=PLpbcUe4chE7-5t2mlamz6yB0qzAfO5Yln&v=hAmcxAmbLcA
1. List View Data Template Selector - https://www.youtube.com/watch?list=PLpbcUe4chE7-5t2mlamz6yB0qzAfO5Yln&v=pdsEHEjyR-4
1. Advanced Xamarin Forms MVVM - https://www.youtube.com/watch?list=PLpbcUe4chE7-uGCH1S0-qeuCWOMa2Tmam&v=USn6hgk-tLU
1. Data Template Selector - https://www.youtube.com/watch?list=PLpbcUe4chE7-uGCH1S0-qeuCWOMa2Tmam&v=WByQQwctYgI

 
### Tasks done:

* Data Template Selector:<br>
	ListView uses default data template. Thus this is to add a custom data     template to the listView items. Override the default template, we can use different custom made data templates.
<br>How to override the behaviour of ListView?
<br>Use concept - Data Template Selector- responsible to let ListView to know which Data template to be selected
<br>Pre-Requisites:
-Create a model Employee with members Name and Department.
* Step 1- Right click Portable project - Add new Folder(for data templates) name it UI- Add new item ( Since there is no specific item for data templates, we use Forms xaml page)- name it FirstDataTemplate
* Step 2- By default, it is a content page. We have to change it to ViewCell in xaml page. It should be noted that the code behind page is also changed such that Content page is replaced by ViewCell.
* Step 3- Specify the properties of the Data Template such as StackLayout, font, Label etc.
* Step 4 - Create another template in the same manner.
* Step 5- Add a new cs file in UI folder named CustomDataTemplateSelector. Inherit the class DataTemplateSelector( Make sure the Xamarin.Forms is the updated version. I have used the version: 2.5.0.121934
* Step 6- Override the OnSelectTemplate method and write the logic as to which data template to use and when( for instance according to the item )
<br>Uploaded the application to my git repository :
	https://github.com/liyanafzl/TasksFantacode/tree/master/Task9/Week9
