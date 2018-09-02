using System;

namespace GTMIS.Model
{
    //T_SysDictType
    public class T_SysDictType
    {

        /// <summary>
        /// FDictTypeId
        /// </summary>		
        public int FDictTypeId { get; set; }
        /// <summary>
        /// FTypeName
        /// </summary>		
        public string FTypeName { get; set; }
        /// <summary>
        /// FParentId
        /// </summary>		
        public int FParentId { get; set; }
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