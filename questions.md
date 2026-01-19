1. Can change some attributes of order to nullable?

2. e.g. in asg write up, DeliveryDateTime: DateTime
   but DeliveryDateTime is not defined until Customer pays and Restaurant accepts order

3. In CreateOrder(), it says to "prompt the user to enter the special request, only 1 is allowed" but in the diagram, there is only a "customise" attribute for the FoodItem. how will we know which foodItem to count this under?

4. In feature 6, theres a Refund Stack. When and where will that be used? Will it be functional and return customer their money? or is it just for decoration?

5. In feature 6, if skipping order and check of order status is "Cancelled".
    Do we need to modify order to "Cancelled"? technically by 'skipping', just means leave it unhandled.

6. Are helper functions allowed?
