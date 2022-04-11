﻿using Dapper;

namespace WebApi
{
    //GetMultipleAsync, Postman, return ile model dönme
    public interface IDapperRepository
    {
        Task<TDto> QueryFirstOrDefaultAsync<TDto>(string sql, object param = null);
        Task<IEnumerable<TDto>> QueryAsync<TDto>(string sql, object param = null);
        Task<SqlMapper.GridReader> GetMultipleAsync(string sql, object param = null);
        Task<int> ExecuteAsync(string sql, object param = null);
    }
}
