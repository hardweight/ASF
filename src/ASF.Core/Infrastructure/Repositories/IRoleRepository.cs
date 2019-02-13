﻿using ASF.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASF.Infrastructure.Repositories
{
    public interface IRoleRepository : IRepository<Role, int>
    {
        /// <summary>
        ///根据角色标识获取角色集合
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<List<Role>> GetList(IList<int> ids);
        /// <summary>
        ///获取角色集合
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<List<Role>> GetList();
        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="account">角色信息</param>
        /// <returns></returns>
        Task ModifyAsync(Role role);

        /// <summary>
        /// 修改角色状态
        /// </summary>
        /// <param name="enable">是否可用</param>
        /// <returns></returns>
        Task ModifyAsync(int roleId,bool enable);
    }
}