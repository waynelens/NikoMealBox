namespace NikoMealBox.Models.DataTable
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.CompilerServices;

    public partial class Orders:BaseEntity
    {   
        /// <summary>
        /// �ӵ��q�檬�A
        /// </summary>
        public int OrderStatusId { get; set; }

        /// <summary>
        /// �w�p���f�ɶ�
        /// </summary>
        public DateTime GetProductDate { get; set; }

        /// <summary>
        /// �f���e�F����ɶ�
        /// </summary>
        public DateTime FinishDate { get; set; }

        /// <summary>
        /// ���f�a�}: ����
        /// </summary>
        [StringLength(50)]
        public string PickUpCity { get; set; }

        /// <summary>
        /// ���f�a�}: ��
        /// </summary>
        [StringLength(50)]
        public string PickUpRegion { get; set; }

        /// <summary>
        /// ���f�a�}: ��l�a�}
        /// </summary>
        [StringLength(50)]
        public string PickUpAddress { get; set; }

        /// <summary>
        /// �s���q��
        /// </summary>
        [StringLength(15)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// �q�ܤ���
        /// </summary>
        [StringLength(8)]
        public string Extention { get; set; }

        /// <summary>
        /// �B�O
        /// </summary>
        public decimal ShippingFee { get; set; }
    }
}