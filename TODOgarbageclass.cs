using System;
using System.Collections.Generic;
using System.Text;

namespace swe_3313_gui
{
    class TODOgarbageclass
    {
        ///this class is to be deleted, but stores what needs to be done in the future. it's ordered by importance from
        ///top to bottom
        ///
        ///-implement the ProgramControl singleton!! objects will be created in the singleton and referenced globally
        ///https://csharpindepth.com/articles/singleton
        ///
        ///-implement a dictionary object to track Screen objects (such as Login and TableView). for example, instead 
        ///of creating a new TableView object and closing the Login object after the user logs in, the program will 
        ///reference the already created Screen object in the dictionary using the singleton class
        ///
        ///-use the same dictionary process mentioned above with back buttons as well
        ///
        ///-Employee class object needs to be created before the user logs in so the login button click event can check
        ///the Employee object's user & pass info to see if it matches. right now the login is hardcoded as "a"
        ///
        ///-TableView onclick button event handling needs to be implemented. check the TableView.Designer.cs class to see the 
        ///foundation of this implementation. ask me (Collier) if you can't find it or don't understand it. when ANY of the table
        ///buttons are clicked, the OrderView screen will load with that table's info (accessed from the corresponding object
        ///in the ProgramControl class)
        /// 
        ///-the OrderView [Design] page needs to be designed based on the figma markup and needs functionality. it must be 
        ///accessed from the TableView screen when the user clicks one of the table buttons. a back button must bring the
        ///user back to the SAME OrderView page. this will be done using the dictionary and ProgramControl
        ///
        ///-table info will be updated while the OrderView screen is being used. table button color in the TableView screen needs
        ///to be adjusted based on the status of the table. BY DEFAULT EVERY TABLE IS GREEN (open). table orders need to be adjusted as well
        /// 
        ///-Restaurant class needs to be fleshed out. include an array called RestaurantTables, which holds Table objects. also
        ///include a method for retrieving Tables by id
        ///
        ///-Menu class needs to be created and implemented to add items to orders
        ///
        ///-Fonts, text size & color, and all colors need to be updated to match those in figma
        

    }
}
