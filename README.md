# ChatBot

## Summery

This is a demo project for School about Macince learing
and will be use as a intro into the topic


### Case

Make a chatbot / Small talk bot with the intent of using it for a website or
on a alderly home to give them some form of companyenship in lonly times like
Corona


#### Case task

I wil be focusing on making the staring to a chatbot wicth will include the following:

this will be done with 2 ML's that will have at least 2 generations

- Identify a smalltalk sentence into 1 of 82 categorye / intents
- Identify a smalltalk sentences focusArea (how does the sentece focus on liek Me, you it, that and so on)
- Can take feedback form the user if the predictions were not wrong (it will be savede to use for the next genaration)
- Can Send a pre-programed sentence back depending on the predictions for Intent And FocusArea


### Dataset

This is the Main Dataset that will be used:

[Main Dataset](https://www.kaggle.com/datasets/salmanfaroz/small-talk-intent-classification-data)

I have further the data by soring it and, making a new coloum called FocusArea for the secound ML
and i will lastly make a csv file with the repsonses acouding to Intent and FocusAreas

I will be traying 3-4 genarations byt tringing with the full set, top half and bottom half of the dataset

<br/>

## Trainging Algorithems

For Intent the Trainging Algorithem used is: <br/>
LbfgsMaximumEntropyMulti

for more information see:
[LbfgsMaximumEntropyMulti](https://learn.microsoft.com/en-us/dotnet/api/microsoft.ml.trainers.lbfgsmaximumentropymulticlasstrainer?view=ml-dotnet)

<br/>

For FocusArea the Trainging Algorithem used is: <br/>
LightGbmMulti

for more information see:
[LightGbmMulti](https://learn.microsoft.com/en-us/dotnet/api/microsoft.ml.trainers.lightgbm.lightgbmmulticlasstrainer?view=ml-dotnet)


<br/>
<br/>


## FolderStrukture

´´´

C:.
├───ChatBotWeb
│   ├───Data
│   ├───Pages
│   ├───Properties
│   ├───Shared
│   └───wwwroot
│       
├───Dataset
├───MLModelFocusArea
│   
├───MLModelFocusArea1
│   
├───MLModelFocusArea2
│   
├───MLModelFocusArea3
│   
├───MLModelIntent
│   
├───MLModelIntent1
│  
└───MLModelIntent2

´´´



## Librarys

### ChatBotWeb
| Name                        | Version |
| :-------------------------- | :------ |
| Blazorise.Bootstrap         | 1.1.1   |
| Blazorise.Icons.FontAwesome | 1.1.1   |
| Radzen.Blazor               | 4.1.9   |

<br/>

### MLModelFocusArea
| Name | Version |
| :--- | :------ |

<br/>

### MLModelFocusArea1
| Name                  | Version |
| :-------------------- | :------ |
| Microsoft.ML          | 1.7.1   |
| Microsoft.ML.FastTree | 1.7.1   |

<br/>

### MLModelFocusArea2
| Name         | Version |
| :----------- | :------ |
| Microsoft.ML | 1.7.1   |

<br/>

### MLModelFocusArea3
| Name                  | Version |
| :-------------------- | :------ |
| Microsoft.ML          | 1.7.1   |
| Microsoft.ML.LightGbm | 1.7.1   |

<br/>

### MLModelFocusArea4_API
| Name                    | Version |
| :---------------------- | :------ |
| Microsoft.Extensions.ML | 1.5.5   |
| Swashbuckle.AspNetCore  | 6.1.4   |
| Microsoft.ML            | 1.7.1   |
| Microsoft.ML.LightGbm   | 1.7.1   |

<br/>

### MLModelIntent
| Name | Version |
| :--- | :------ |

<br/>

### MLModelIntent1
| Name         | Version |
| :----------- | :------ |
| Microsoft.ML | 1.7.1   |

<br/>

### MLModelIntent2
| Name         | Version |
| :----------- | :------ |
| Microsoft.ML | 1.7.1   |

<br/>

### MLModelIntent3_API
| Name                    | Version |
| :---------------------- | :------ |
| Microsoft.Extensions.ML | 1.5.5   |
| Swashbuckle.AspNetCore  | 6.1.4   |
| Microsoft.ML            | 1.7.1   |






