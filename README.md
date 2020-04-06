# GroceryExpressProject

Nowdays, People are facing problem to go outside because of this virus (COVID-19). Grocery is neccery thing and for that people have to go outside which is very risky. so to overcome that problem i decided to make online grocery shopping website. in which customer gets free delivery to their house.
In this website i have created three role
1) Admin- who can manage all the thing, product management and can perform CRUD.
2) User - who can view the products and can perform CRUD on Orders Customer data.
3) DeliveryDriver - who can view the orders and can perfom CRUD on Drivers Data.

#Database Design
1)Product Table
![Screenshot (138)](https://user-images.githubusercontent.com/55421788/78521949-ba72aa80-7799-11ea-98f5-1e44b563ff17.png)

2)Customer Table
![Screenshot (135)](https://user-images.githubusercontent.com/55421788/78522014-eb52df80-7799-11ea-85c4-5b6c6d1aa192.png)

3)Driver Table
![Screenshot (136)](https://user-images.githubusercontent.com/55421788/78522058-0b829e80-779a-11ea-8539-c7bd31c60bdd.png)

4)Order Table
![Screenshot (137)](https://user-images.githubusercontent.com/55421788/78522083-1fc69b80-779a-11ea-8338-c9a945b89afc.png)

#CRUD Operation

1)Creating the Customer
![Screenshot (140)](https://user-images.githubusercontent.com/55421788/78566553-62fe2a00-77ed-11ea-9b18-432d0261ff6d.png)

2)Editing the Customer
![Screenshot (144)](https://user-images.githubusercontent.com/55421788/78566946-ed468e00-77ed-11ea-93c8-0adaa552c96f.png)

3)Retriving the Information of Customer
![Screenshot (142)](https://user-images.githubusercontent.com/55421788/78566816-c720ee00-77ed-11ea-8be3-4f42e3475089.png)

4)Deleting The Customer
![Screenshot (143)](https://user-images.githubusercontent.com/55421788/78567034-10713d80-77ee-11ea-810d-8cac7cfdca79.png)


#Role Implementation
Administration Controller- only admin can access that controller. so admin can create a role and update a role
i have hide createrole and listRole links, only admin can see thoes links.
