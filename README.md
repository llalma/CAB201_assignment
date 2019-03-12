# CAB201_assignment
2nd year software engineering assignment, using c# with .NET framework

####Task

For this assignment your task is to develop a program for a car rental company called Mates Rates
Rent a Car (MRRC) to help the operators of the company more efficiently manage their fleet of cars
and their customers.
The operators of MRRC require the following functionality:
1. Enter/modify/delete customers
2. Enter/modify/delete cars
3. Search for suitable vehicles based on customers’ requests
4. Rent out cars to customers
5. Return cars from customers
6. Display a rented cars report
It offers vehicles in 4 classes –
• Economy
• Family
• Luxury
• Commercial
Vehicles have various traits. A Vehicle class defines the shared properties and methods of all cars and
support specialised properties and methods. For instance, luxury cars have GPS and opening roof,
and commercial vehicles may have a diesel engine. Number of seats in cars may vary from 2 to 10
(fixed per car though.) Each car has a (possibly) unique rental cost per day.
Customers have various traits. A Customer class defines the shared properties and methods of all
customers. Attributes required are Name (with suitably defined sub-fields), and Date of birth (with
suitably defined sub-fields).
These classes are used by:
A Fleet class manages the rental of vehicles. The fleet class should load the vehicle fleet from
file on start-up. This class should be based on an array of Vehicle objects. It should support
operations on the fleet (e.g. add/modify/delete)
A CRM class manages the collection of customers. The CRM class should load the customers
from file on start-up. This class should be based on an array of Customer objects. It should
support operations on the Customer (e.g. add/modify/delete)
Both the Fleet and CRM classes should save their data to disk when the program is closed by the
operator.
Upon start-up, the program has to load the Fleet (vehicles) and CRM (customers) from permanent
storage on disk files. During operation the in-memory system is used to manage all operations. When
the program is finished it must save the Fleet and CRM data to disk.
