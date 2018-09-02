using System;

namespace GTMIS.Model
{
    //T_SysDictData
    public class T_SysDictData
    {

        /// <summary>
        /// FDictDataId
        /// </summary>		
        public int FDictDataId { get; set; }
        /// <summary>
        /// FDictTypeId
        /// </summary>		
        public int FDictTypeId { get; set; }
        /// <summary>
        /// FDispName
        /// </summary>		
        public string FDispName { get; set; }
        /// <summary>
        /// FDictValue
        /// </summary>		
        public string FDictValue { get; set; }
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