**

**

# Lawyer's Office | API Web Application

**A System to managing a lawyer's office**
Through the system, the lawyer will be able to manage his clients' files, and their payments
___


## **Entities:**

 - Costumer
 - CourtCase
 - Payment




## Routing

**Mapping routes for a Costumer:**

 - Get all the costumers
GET https://lawyer.co.il/Costumer

 - Get costumer by identity
GET https://lawyer.co.il/Costumer/1

 - Add new costumer
 POST https://lawyer.co.il/Costumer

 - Update exists costumer
 PUT https://lawyer.co.il/Costumer/1

**Mapping routes for a CourtCase:**

 - Get all the court cases
 GET https://lawyer.co.il/CourtCase
 
 - Get court case by identity
 GET https://lawyer.co.il/CourtCase/1
 
 - Get all the court cases from a known date
GET https://lawyer.co.il/CourtCase/date?date=01.01.2023

 - Add new court case
 POST https://lawyer.co.il/CourtCase
 
 - Update exists court case
PUT https://lawyer.co.il/CourtCase/1

 - Update the court case status of exists court case
PUT https://lawyer.co.il/CourtCase/1/status


**Mapping routes for a Payment:**

 - Get all payments
 GET https://lawyer.co.il/Payment
 
- Get payment by identity
GET https://lawyer.co.il/Payment/1

- Add new payment
POST https://lawyer.co.il/Payment

- Update an exists payment
PUT https://lawyer.co.il/Payment/1

- Update sum of exists payment
PUT https://lawyer.co.il/Payment/1/sum?sum=500

- Delete a payment
DELETE https://lawyer.co.il/Payment/1

---
opened by bracha goldberg  | https://github.com/BrachiGoldberg |  brachig404@gmail.com
