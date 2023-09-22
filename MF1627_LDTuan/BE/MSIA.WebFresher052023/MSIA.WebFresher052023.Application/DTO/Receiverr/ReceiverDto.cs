﻿namespace Application.DTO
{
    public class ReceiverDto
    {
        #region Fields
        /// <summary>
        /// Id của người nhận
        /// </summary>
        /// Created by: ldtuan (27/08/2023)
        public Guid ReceiverId { get; set; }

        /// <summary>
        /// Mã code của người nhận
        /// </summary>
        /// Created by: ldtuan (27/08/2023)
        public string ReceiverCode { get; set; }

        /// <summary>
        /// Họ tên đầy đủ của người nhận
        /// </summary>
        /// Created by: ldtuan (27/08/2023)
        public string ReceiverFullname { get; set; }

        /// <summary>
        /// Người đại diện nhận
        /// </summary>
        /// Created by: ldtuan (27/08/2023)
        public string ReceiverDelegate { get; set; }

        /// <summary>
        /// Chức vụ của người nhận
        /// </summary>
        /// Created by: ldtuan (27/08/2023)
        public string ReceiverPosition { get; set; }

        /// <summary>
        /// Id của chứng từ
        /// </summary>
        /// Created by: ldtuan (27/08/2023)
        public Guid TransferAssetId { get; set; }
        #endregion
    }
}