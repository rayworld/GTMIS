using System;

namespace GTMIS.Model
{
    //T_SysDept
    public class T_SysDept
    {

        /// <summary>
        /// FDeptID
        /// </summary>		
        public int FDeptID { get; set; }
        /// <summary>
        /// FDeptName
        /// </summary>		
        public string FDeptName { get; set; }
        /// <summary>
        /// FParentID
        /// </summary>		
        public int FParentID { get; set; }
        /// <summary>
        /// FOrder
        /// </summary>		
        public int FOrder { get; set; }
        /// <summary>
        /// FCreateBy
        /// </summary>		
        public string FCreateBy { get; set; }
        /// <summary>
        /// FCreateDate
        /// </summary>		
        public DateTime FCreateDate { get; set; }

    }
}