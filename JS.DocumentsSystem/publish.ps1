﻿# 生成版本号
#$version = Get-Date -Format "yyyyMMddHHmm"
$version = "latest"

# 执行 dotnet clean
dotnet clean

# 执行 dotnet restore
dotnet restore

# 执行 dotnet publish
dotnet publish -c Release

# 执行 docker build
docker build -f Dockerfile.local -t "registry.cn-shenzhen.aliyuncs.com/js_api/platform-authserver:$version" .

# 执行 docker push
docker push "registry.cn-shenzhen.aliyuncs.com/js_api/platform-authserver:$version"

"发布成功，版本号 $version "
Pause