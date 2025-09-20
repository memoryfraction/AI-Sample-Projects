# Ollama + Llama3.2-vision + C#/.NET Image interact app development steps

## 摘要
本项目描述了如何使用本地LLM识别图片，并给出图片中的信息的文字描述

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
In this project, a picture can be parsed and described using text with an LLM.

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
