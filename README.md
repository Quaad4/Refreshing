# Library Management System (Console App)

#Core features to implement:
#Classes & Inheritance

-Abstract base class: LibraryItem

-Properties: Id (auto-increment), Title

-Abstract method: DisplayInfo()

-Derived classes: Book, Magazine, DVD

-Each overrides DisplayInfo() to show item-specific details

#Interfaces

-IBorrowable interface with methods:

-Borrow()

-Return()

-Only Book and DVD implement IBorrowable (magazines can’t be borrowed)

#Encapsulation & Properties

-Use private fields and public properties

-Auto-increment Id with a static counter in LibraryItem

#Exception Handling

-Handle borrowing an already borrowed item

-Handle returning an item that isn’t borrowed

#Basic Menu Interaction

-Add some console-based menu options to:

-Add items to the library

-List all items

-Borrow/Return items by Id

-Exit
