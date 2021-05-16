using System;

namespace MyWeb.Models
{
    public abstract class BaseModelDate<T>
    {
        public T Id { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset  UpdateDate { get; set; }
    }
}