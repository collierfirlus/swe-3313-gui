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
       
        ///
        ///-Employee class object needs to be created before the user logs in so the login button click event can check
        ///the Employee object's user & pass info to see if it matches. right now the login is hardcoded as "a"
        ///
        ///-table info will be updated while the OrderView screen is being used. table button color in the TableView screen needs
        ///to be adjusted based on the status of the table. BY DEFAULT EVERY TABLE IS GREEN (open). table orders need to be adjusted as well
        ///
        ///
        ///
        ///-event handling needs to be finished for all of the table buttons in TableView
        ///
        ///-add the rest of the tables to the list in ProgramControl
        ///
        ///-Fonts, text size & color, and all colors need to be updated to match those in amfig

        //---------------------------examples
        //Get tables from ProgramControl
        //ProgramControl.GetInstance().Restaurant.GetTables();

        //get specific table
        //ProgramControl.GetInstance().Restaurant.GetTableById(
        //    ProgramControl.GetInstance().TableCurrentlySelected
        //    );

    }
}
