using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webpage.Models
{
    public class ImageModel
    {
        public List<string> m_lsImages = new List<string>();
        public ImageModel()
        {
            m_lsImages = new List<string>();
        } 
        public List<string> Images
        {
            get { return m_lsImages; }
            set
            {
                m_lsImages = value;
            }
        }
    }
}