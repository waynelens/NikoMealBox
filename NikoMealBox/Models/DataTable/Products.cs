namespace NikoMealBox.Models.DataTable
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products : BaseEntity
    {
        /// <summary>
        /// �ӫ~�W��
        /// </summary>
        [Required]
        [StringLength(20)]
        public string ProductName { get; set; }

        /// <summary>
        /// �ӫ~����
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// �ӫ~���
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// �ӫ~�w�s
        /// </summary>
        public int UnitsInStock { get; set; }

        /// <summary>
        /// �ӫ~²�z
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        /// <summary>
        /// �ӫ~����
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Materials { get; set; }

        /// <summary>
        /// ���q
        /// </summary>
        public decimal Calories { get; set; }

        /// <summary>
        /// �Ҥ��ƦX��
        /// </summary>
        public decimal Carbohydrate { get; set; }

        /// <summary>
        /// �J�ս�
        /// </summary>
        public decimal Protein { get; set; }

        /// <summary>
        /// �ת�
        /// </summary>
        public decimal Fat { get; set; }

        /// <summary>
        /// ���M�ת�
        /// </summary>
        public decimal SaturatedFat { get; set; }

        /// <summary>
        /// �Ϧ��ת�
        /// </summary>
        public decimal TransFat { get; set; }

        /// <summary>
        /// �}
        /// </summary>
        public decimal Sugar { get; set; }

        /// <summary>
        /// �u
        /// </summary>
        public decimal Sodium { get; set; }

        /// <summary>
        /// �ӫ~�Ϥ����|
        /// </summary>
        [Required]
        [StringLength(256)]
        public string ImagePath { get; set; }

        /// <summary>
        /// �J����
        /// </summary>
        public bool IsOvolacto { get; set; }

        /// <summary>
        /// ���~/�����O�_�٦�����
        /// �e�ݤ�����ܡA������U��
        /// </summary>
        public bool IsEnable { get; set; }


    }
}