## Anime Project
By Nsama Chibulu 



1. Brief.
2. Project Tracking.
3. Risk Assessment. 
4. Architechture - User Interaction
5. Architechture Database structure and CI Pipeline.
6. Build.
7. Testing.
8. Issues that Occured.
9. What better to do next time. 
10. Final Product.



## Brief

For my SFIA project, I decided to create an app that tracks the animes I watch monthly. As someone who can finish a show in one sitting, I find it hard to remember what anime I've watched, the ones I do want to watch, and the ones I am currently watching. Thus, I beleieve this application would personally help me keep track with all the ones I am watching. I have a similiar issues in regards to Korean Dramas, and had planend to incoporate a third table to shwcase my kdramas. However, with the time constraint, I was unable to create this third table.  The app is intended to be public and be of a CRUD nature (Create, Delete, Update and Delete). 




# Project Requirements


The project, which utilizes the SFIA Framework and SDLC was given to us to showcase our skills and create a CRUD (Create, Read, Update and Delete) application.  On the specification, certain requirements for the project were needed to be able to produce a MVP.

Requirements : MoSCow

Must Haves. 
-	A Kanban board detailing the whole project management aspect, featuring user stories, cases and task.
-	The application must be a CRUD app. This means that’s you, the user, must be able to create an entry, read the entry , update the entry and delete the entry. 
-	The app must draw out information from a MySQL relational database. There must be two tables MINIMUM. 
-	The app must be created in C#, with a backend and frontend. 
-	There must be Test suites available for the backend and front end programming, to ensure high test coverage in the backend.
-	Code must be then fully integrated into a Version Control System, to be built through a command line server and deployed to a virtual machine with CI pipleines. 
-	Documentation must also be provided to that describe the full design and architecture of the project. 
-	Must included a Risk assessment within the documents. 
-	Must be submitted as a README.md file on the 10th May at 9am. 


Should be’s/have.
-	A record of all issues encountered within the Kanban board, to track issues and risks that have occurred.
-	App should be user friendly, have clear syntax on the interactive pages and should have easy accessibility to necessary pages. 
-	Should be using GitHub as the Version Control system as this would be easier and familiar to use. 
-	Time constraints on each individual epic/user story/task so that it will be possible to provide of required material by the deadline. 
-	Front end done on ASP.NET

Could be’s/Have.
-	A front end designed on Angular.
-	Use a Jira software for the Kanban Board, as this can be integrated into GitHub for easy access and view. 
-	Have more than 2 tables in SQL, ideally as many needed to capture the data required to make the app perform how it should. 
Would be’s/Have
-	Enjoyable to use by customer. 
-	Can be accessed on all devices. 


## Project Tracking
For the tracking of the porject, two boards where used. One was a Kanban Board hosted on Jira, the next was a scrum board hosted on Azure DevOpds.
![image](https://user-images.githubusercontent.com/82107226/117542433-89a21c00-b010-11eb-8690-8ef3b425d3af.png)

On the above Jira Board, I was able to obtian a visual Roadmap which showcased the different Epics (in purple) that I was required to work on. Benethe them was the Stories(in Green) thats were linked to that specific epic, followed by task. This board was great for visually seeing where my project was in terms of past, present and futre workloads and deadlines. However, I decided to go with Azure DevOps to ensure that my developing, delivering and sustaining was monitored through sprints.Azure DevOps was my chosen software for my scrum board as it easily allows me to store repos , create pipleines and monitor sprints.
Throughtout the projects, there were three sprints; Planning(which included design), Building and Testing/Deployment of the application. 
Sprint 1 ; 
![image](https://user-images.githubusercontent.com/82107226/117543710-d805e980-b015-11eb-8096-1a04b409bc36.png)

Sprint 2 ;
![image](https://user-images.githubusercontent.com/82107226/117543680-bdcc0b80-b015-11eb-9ef5-e2acd1ba6078.png)

Sprint 3; 
![image](https://user-images.githubusercontent.com/82107226/117543651-a2f99700-b015-11eb-851b-2d2e3d86bfc8.png)


## Risk Assessment
Before any work could be carried out, a Risk Assessment was created. 
![image](https://user-images.githubusercontent.com/82107226/117543785-3b901700-b016-11eb-843a-ff0a5bbb7fde.png)


## Architecture- User Interaction 

One thing I wanted my app to have was ease of accessibility. I wanted to create an app which is easy to use and secure. Below is a flow chart on how I wanted my user to interact with my app on their first instance. 

![image](https://user-images.githubusercontent.com/82107226/117544230-64191080-b018-11eb-824e-3957d7ca31d9.png)


## Architecture - Databases

The application will run on one MySQL database called "Proanime". This databsse is hosted in Azure Database for MySQL. 
![image](https://user-images.githubusercontent.com/82107226/117544351-f3262880-b018-11eb-8e5e-e9f965cebbf0.png)
The database has two tables; Months and Animes. Months is the parent table and Animes is the child table. This means that, an Anime cannot be created unless it is linked to Month entry. A Month can have many animes, but an anime cannot be assigned to multiple months.

On the MySQL WorkBench, we can see the database has these two table, linked and ready to use in our app. We can then describe each table to show the fields, the datatypes needed for each field amd their keys. 
![image](https://user-images.githubusercontent.com/82107226/117544511-c58daf00-b019-11eb-8786-90c10d05c56d.png)

![image](https://user-images.githubusercontent.com/82107226/117544626-3c2aac80-b01a-11eb-8b06-8f0c68a5204a.png)

![image](https://user-images.githubusercontent.com/82107226/117544642-4f3d7c80-b01a-11eb-8a94-4c082a646db8.png)

Below is the Entity-Relationship Diagram (ERD). Here we can visually see the relationship between the two tables. The tables have a Many relationship, once again resonating the fact that a month can have multiple animes. 

![image](https://user-images.githubusercontent.com/82107226/117545183-988ecb80-b01c-11eb-800d-ed957c795b1d.png)



## Build 

The back and frontend build of the application was done within Visual Studio, using C# for the ASP.NET Core framework and Java/HTML for the viewing pages. To create the app, we used ASP.NET Core WebA APP (Model-Control-View). This allowed us to create the app whilst having access to the layout, logic and display of the application. 
The application contains two controllers; MonthsController and AnimesController. This is where a majoirty of the my logis was found. 

![image](https://user-images.githubusercontent.com/82107226/117545894-a134d100-b01f-11eb-891a-6fd2aca6e1fc.png)


Below are pictures of my frontend design, 

- Home Page

![image](https://user-images.githubusercontent.com/82107226/117545537-199a9280-b01e-11eb-864f-57f36f6f2c22.png)


- Months Page 

View all Months
![image](https://user-images.githubusercontent.com/82107226/117545800-413e2a80-b01f-11eb-8a3f-f4e9c0be3998.png)

Create
![image](https://user-images.githubusercontent.com/82107226/117545583-4ea6e500-b01e-11eb-87f1-3589343685d5.png)

Update
![image](https://user-images.githubusercontent.com/82107226/117545615-7302c180-b01e-11eb-8e00-21a3b2b1d3f6.png)

View Details 
![image](https://user-images.githubusercontent.com/82107226/117545666-a7767d80-b01e-11eb-9958-115ba623778d.png)

View Animes for that month
![image](https://user-images.githubusercontent.com/82107226/117545788-34213b80-b01f-11eb-9f61-915f6ce6e65e.png)



- Animes Page 

View All Animes
![image](https://user-images.githubusercontent.com/82107226/117545810-4e5b1980-b01f-11eb-89f3-acd69825ff67.png)

Update Anime
![image](https://user-images.githubusercontent.com/82107226/117545855-79de0400-b01f-11eb-9823-030ac34125b6.png)

View Details 
![image](https://user-images.githubusercontent.com/82107226/117545867-85c9c600-b01f-11eb-82ed-403e92f8c32d.png)



## Testing 

For testing, the xUnit framework was used to carry out the unit testing. The following image shows the tests run and also what was being tested.

![image](https://user-images.githubusercontent.com/82107226/117546123-d857b200-b020-11eb-912e-56fa46844c93.png)

A test coverage was also generated.
![image](https://user-images.githubusercontent.com/82107226/117546096-a21a3280-b020-11eb-80df-a7a80f6568ce.png)


## Issues that occured

- CI Pipeline
For my Continuous Integration pipeline, I was hoping to use Azure Pipelines. I chose Azure Pipeliens as it was hosted in Azure DevOps, allowing to easily pull my code into the Repos and use that easily run my pipeline. Once created , the following Yaml file was generated. 

![image](https://user-images.githubusercontent.com/82107226/117546537-cb3bc280-b022-11eb-91f3-c4175c12dfa8.png)

However, the pipeline failled to run to due to the follwoign error. Given the time constriants of the projetc, I was unable to troubleshoot the error and run the pipeline again. 

![image](https://user-images.githubusercontent.com/82107226/117546635-4604dd80-b023-11eb-90b6-22eea73fe3a1.png)

- Low Test Coverage
When it came to test performance, my line coverage was very low. For an application to be exceptional, all logic within the application should be tested. That is, where you're telling the app to do something, there must be a test in place to ensure that it is actually doing it. As I only thought that the contorllers held such commands, I was proven wrong with the low figures. Especially within my controllers, where I was not able to test only one Create method(the CreateAnime method was consistently failing but I was able to create an anime, meaning my syntax for that speicifc test was wrong).

- Time
Throughout the entire project, it was evident that time was an issue. With tasks taking longer than expected (espeically testing), I found myself rushing and not being able to go back and make the desired changed I wanted

## Improvements 

- Angular
For the frontend , Angular would've been the best option. Not only would it have allowed the application to be more visually appealing, but would've allowed seperate tests to take place (Jasmine Testing) to ensure that the frontend was robust and fully functioning. 


- "If theres ever an issue, Let the customer know"
One thing I did not do well is express my concerns about the project with my instructors until it was too late. For future projects, I will ensure that I am constantly updating my client if there are any concerns.

-Time management 
To esnure that time managementproperly performed, I will ensure I know the time lenght of each task, instead of assuming and guessing. This will ensure that I have the right amount of time for each task, preventing me from fallling behind andstressing myself out with worry that I wont be able to complete a requirement. 

- Linking the pages
An imporvement I would've loved to do was make the pages interlinking. This would've been achieved via the View csHtml files. However, with the limited amount of time I had and the issues that occured, I was unable to add this feature that would've made user interacting more enjoyable. 

## Final Product = A deployed App !!

Using Azure App Service, I was able to deploy my aplication successfully. The URL is https://nsamaanime.azurewebsites.net/ 

![image](https://user-images.githubusercontent.com/82107226/117547413-620a7e00-b027-11eb-82c5-a87178d276b9.png)

![image](https://user-images.githubusercontent.com/82107226/117547426-76e71180-b027-11eb-9dfc-b4ca0af895fd.png)

