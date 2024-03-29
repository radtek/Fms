﻿using System;
using System.Collections.Generic;
using Easyman.Dto;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Web.Mvc;
using EasyMan.Dtos;

namespace Easyman.Service
{
    /// <summary>
    /// 终端共享文件夹管理
    /// </summary>
    public interface IFolderAppService : IApplicationService
    {

        /// <summary>
        /// 根据ID获取某个终端共享文件夹
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        FolderModel GetFolder(long id);
        /// <summary>
        /// 更新和新增终端共享文件夹
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        FolderModel InsertOrUpdateFolder(FolderModel input);

        /// <summary>
        /// 删除一条终端共享文件夹
        /// </summary>
        /// <param name="input"></param>
        void DeleteFolder(EntityDto<long> input);
        /// <summary>
        /// 获取终端共享文件夹json
        /// </summary>
        /// <returns></returns>
        IEnumerable<object> GetFolderTreeJson();
        /// <summary>
        /// 获取所有类型List
        /// </summary>
        /// <returns></returns>
        List<SelectListItem> FolderList();
        /// <summary>
        /// 根据终端编号获取共享目录
        /// </summary>
        /// <param name="computerId"></param>
        /// <returns></returns>
        [System.Web.Http.HttpGet]
        List<FolderModel> GetFolderListByComputer(long computerId);
        /// <summary>
        /// 根据终端，文件夹名称获取共享文件夹
        /// </summary>
        /// <param name="cid"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        FolderModel GetFolderByComputerAndName(long cid, string name);
    }
}
