# 爬爬乐园

## 目标

* 爬取美女网站图片【已实现】
* 爬取给定的网站的全部图片、视频、网页、样式、程序的资源
* 建立已爬取的信息的搜索引擎和资讯中心
* 做一个爬虫管理中心，支持导入/卸载爬虫组件包、启动暂停爬虫、呈现爬虫爬过的网、汇总爬虫使用的系统资源比例
* 爬取淘宝、京东的格式化的商品信息
* 根据给定的知识，在网上爬取关联的知识，通过互联网爬取建立知识库
* 给知识库做一个漂亮的云图的展示和编辑界面

## 项目首页

NetCrawler  .netcore        [首页](./NetCrawler/README.md)
Crawler-web .网站项目       [首页](./Crawler-web/README.md)
Crawler     Python项目      [首页](./Crawler/README.md)

## 说明

一些背景资料：

爬虫的项目有两个语言：Python和.net core c#。苦逼的哥花了晚上几个小时找Python连接OrientDB的方法和库，最后确定因为OrientDB版本太新，协议版本比较高，所以对应的Python连接wrapper程序还没有更新，所以Python暂时连接不了OrientDB。查阅官文发现C# .net core是官方支持的驱动之一，而Python不是，所以立马决定连接OrientDB还是使用.netcore C#。