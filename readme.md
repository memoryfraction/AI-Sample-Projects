## 摘要
本地视觉解析器是一个开源的C#项目，利用Ollama和Meta的Llama 3.2视觉模型实现强大的本地图像识别功能。它帮助.NET开发者在无需云端依赖的情况下执行对象检测、文字识别（OCR）和场景分析等任务，保证数据隐私和低延迟。通过Ollama Sharp集成，支持异步工作流，适用于文档处理、电子商务和无障碍工具等场景。项目基于.NET 8+和Ollama v0.3.0+打造，提供轻量级、可扩展的AI视觉开发解决方案，安装简单，适合快速开发。

## 0 下载并安装ollama, 默认安装路径
C:\Users\rongf\AppData\Local\Programs\Ollama\ollama.exe

## 1 下载llama3.2 
下载路径: [https://ollama.com/library/llama3.2](https://ollama.com/)  
找到ollama.exe的安装路径;  然后执行命令: 
```bash
run llama3.2-vision
```

## ​2 常见指令
```bash
ollama list // 检查当前的模型
ollama pull llama3.2-vision // pull model, 必须是vision模型才能识别图片;
ollama run llama3.2-vision // 运行模型
```

## 3 使用repo中的代码，可以交互图片信息
效果图如下
<img alt="result1.png" src="https://github.com/memoryfraction/AI-SAMPLE-PROJECTS/blob/main/projects/LLAMA%203.2%20+%20C%23%20+%20HttpClient/result1.png?raw=true" data-hpc="true" class="Box-sc-g0xbh4-0 fzFXnm"> 


## Summary
LocalVisionParser is an open-source C# project that combines Ollama and Meta’s Llama 3.2 Vision model to deliver robust image recognition on local hardware. It empowers .NET developers to implement tasks like object detection, optical character recognition, and scene analysis without cloud reliance, ensuring data privacy and fast processing. Integrated via Ollama Sharp, it supports asynchronous workflows for applications in document extraction, e-commerce, and accessibility tools. Built for .NET 8+ and Ollama v0.3.0+, this lightweight solution enables scalable, AI-driven vision development with minimal setup.

## 0 Download and install ollama, default path
C:\Users\rongf\AppData\Local\Programs\Ollama\ollama.exe

## 1 Download llama3.2 
Path: [https://ollama.com/library/llama3.2](https://ollama.com/)  
Find ollama.exe Path;  Then execute  
```bash
run llama3.2-vision
```

## ​2 Commands
```bash
ollama list // list all the models
ollama pull llama3.2-vision // pull model
ollama run llama3.2-vision // run the model
```

## 3 Interact with the app
Images
<img alt="result1.png" src="https://github.com/memoryfraction/AI-SAMPLE-PROJECTS/blob/main/projects/LLAMA%203.2%20+%20C%23%20+%20HttpClient/result1.png?raw=true" data-hpc="true" class="Box-sc-g0xbh4-0 fzFXnm"> 
