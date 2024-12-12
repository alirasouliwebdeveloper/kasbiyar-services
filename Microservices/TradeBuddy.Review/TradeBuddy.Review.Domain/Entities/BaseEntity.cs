﻿namespace TradeBuddy.Review.Domain.Entities
{
    public abstract class BaseEntity<TId>
    {
        public TId Id { get; protected set; }
        public DateTime CreateDate { get; protected set; }
        public string? CreateBy { get; protected set; }
        public DateTime? UpdateDate { get; protected set; }
        public string? UpdateBy { get; protected set; }
        public bool IsDeleted { get; protected set; }
        public DateTime? DeleteDate { get; protected set; }
        public string? DeleteBy { get; protected set; }

        protected BaseEntity()
        {
            CreateDate = DateTime.UtcNow;
            IsDeleted = false;
        }

        public void MarkAsDeleted(string deletedBy)
        {
            IsDeleted = true;
            DeleteDate = DateTime.UtcNow;
            DeleteBy = deletedBy;
        }

        public void Update(string updatedBy)
        {
            UpdateBy = updatedBy;
            SetUpdateDate();
        }

        // Method to update UpdateDate inside the BaseEntity class
        protected void SetUpdateDate()
        {
            UpdateDate = DateTime.UtcNow;
        }
    }
}