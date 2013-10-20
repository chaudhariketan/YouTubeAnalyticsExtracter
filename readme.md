YouTube Analytics Extracter C#
To download Analytics data of YouTube channel following inromation is mandetory  : -
•	Client Id
•	Client Secret
•	Refresh Token
•	Resource Id
Where we can find this above information. To find that please go through : -  
•	Client Id & Client Secret : -  
Go to URL: - https://code.google.com/apis/console/.  Login with your YouTube / Google User credentials. 
 
Click on “Create Project”
Then redirected to service page. In that make “YouTube Analytics API”  state “On”. 
 
To 

 

After that now, YouTube Analytics API is now available to use. 
Then select Menu “API Access” from left top menu in same page. & click on “Create an OAuth 2.0 client ID…”
 

On click following popup will show up. In that provide necessary information. & click on next: - 
 

Then click on “Create Client ID”
 

After clicking on “Create Client ID”. Following client id will generate:- 
 
From above you will find out “Client Id” & “Client Secret”.


•	Refresh Token  : - 
To generate Refresh Token please go through video & follow the provided steps from video. You will get the necessary Refresh Token for your YouTube channel project that we have added in above step. 
Video URL: - http://www.youtube.com/watch?v=hfWe1gPCnzc

•	Resource Id: - This id is of YouTube channel. Please login into Your YouTube account & then paste following URL in your browser window & hit enter. Page will show up your YouTube channel ID & user Id. URL: - http://www.youtube.com/account_advanced.
 
If you have all above information. Then you are ready to retrieve YouTube channel information using provided C# windows application. 

Note:  - In this application following Open Source assembles are used.
•	DotNetOpenAuth.dll
•	Google.Apis.dll
•	Newtonsoft.Json.dll
•	Google.Apis.Authentication.OAuth2.dll
•	Used Google YouTube API classes created by google-apis-code-generator 1.4.1


Note: - This application is developed to provide a starter to build out your own YouTube Analytics application.

Future Enhancement: - 
	Addition of more “Dimension’s 
•	Provide facility to segment data by Day, Week, Month, Device Type, Operation system & Country wise etc. Facility to segment data By Dimension:  - Video. Currently application provides analytics data for whole YouTube channel.  But, by inclusion of Video dimension we will get analytics data by Video wise in detail.
	Addition of more “Metrics”

