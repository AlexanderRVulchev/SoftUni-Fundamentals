Input / Constraints
You will receive a journal with some collecting items, separated with a comma and a space (", "). After that, until receiving "Craft!" you will be receiving different commands split by " - ":
•	"Collect - {item}" - you should add the given item to your inventory. If the item already exists, you should skip this line.
•	"Drop - {item}" - you should remove the item from your inventory if it exists.
•	"Combine Items - {old_item}:{new_item}" - you should check if the old item exists. If so, add the new item after the old one. Otherwise, ignore the command.
•	"Renew – {item}" – if the given item exists, you should change its position and put it last in your inventory.
Output
After receiving "Craft!" print the items in your inventory, separated by ", ".
