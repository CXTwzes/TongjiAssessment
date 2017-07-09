using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TongjiAssessment.Models
{
    public class PagingInfo
    {
        private int totalItems;
        private int itemsPerPage;
        private int currentPage;
        private int totalPages;

        public int TotalItems
        {
            get
            {
                return totalItems;
            }

            set
            {
                totalItems = value;
            }
        }

        public int ItemsPerPage
        {
            get
            {
                return itemsPerPage;
            }

            set
            {
                itemsPerPage = value;
            }
        }

        public int CurrentPage
        {
            get
            {
                return currentPage;
            }

            set
            {
                currentPage = value;
            }
        }

        public int TotalPages
        {
            get
            {
                return (int)Math.Ceiling((decimal)totalItems / itemsPerPage); ;
            }
            
        }
    }
}