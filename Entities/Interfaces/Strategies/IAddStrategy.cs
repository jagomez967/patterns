﻿namespace Entities.Interfaces
{
    public interface IAddStrategy<TEntity, TParameters> : IStrategy<TEntity, TParameters> where TParameters:IParameters
    {

    }
}
