using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QRCodeSystem.DataAccess;

namespace QRCodeSystem.BusinessLogic
{
    public class BLRoles
    {
        DARoles daRoles = new DARoles();

        public DataSet GetRoles(String Condition)
        {
            return daRoles.GetRoles(Condition);
        }
        //     Dim daRoles As New DARoles
        //Public Function GetRoles(ByVal Condition As String)
        //     Return daRoles.GetRoles(Condition)
        // End Function

        // Public Function UpdateRoles(ByVal Condition As String)
        //     Return daRoles.UpdateRoles(Condition)
        // End Function

        // Public Function InsertRoles(ByVal Condition As String)
        //     Return daRoles.InsertRoles(Condition)
        // End Function
    }
}