﻿using ASF.Domain.Values;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASF.Infrastructure.Model
{
   public class Account
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int Id { get; private set; }
        /// <summary>
        /// 昵称
        /// </summary>
        [Required, MaxLength(20)]
        public string Name { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [Required, StringLength(32, MinimumLength = 2)]
        public string Username { get; private set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        [Required, StringLength(20, MinimumLength = 6)]
        public string Password { get; private set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public PhoneNumber Telephone { get; set; }
        /// <summary>
        /// 邮箱地址
        /// </summary>
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        [MaxLength(225)]
        public string Avatar { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public AccountStatus Status { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDeleted { get; private set; }
        /// <summary>
        /// 角色集
        /// </summary>
        [Required]
        [MaxLength(20000)]
        public string Roles { get; private set; }
        /// <summary>
        /// 创建用户
        /// </summary>
        public int CreateId { get; private set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; private set; } = DateTime.Now;
        /// <summary>
        /// 最后登录IP
        /// </summary>
        [MaxLength(20)]
        public string LoginIp { get; private set; }
        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime LoginTime { get; private set; } = DateTime.Now;
        /// <summary>
        /// 授权颁发访问Token
        /// </summary>
        public AccessToken AccessToken { get; private set; } = new AccessToken();
    }
}
