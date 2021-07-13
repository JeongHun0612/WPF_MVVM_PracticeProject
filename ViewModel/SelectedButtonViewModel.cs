using System;

namespace PracticeCode.ViewModel
{
    public class SelectedButtonViewModel
    {
        public SelectedButtonViewModel()
        {
            MainViewModel.selectedButtonViewModel = this;

            this.commandNumClick = new DelegateCommand(NumClick);
            this.commandOperatorClick = new DelegateCommand(OperatorClick);
            this.commandDotClick = new DelegateCommand(DotClick);
            this.commandClearClick = new DelegateCommand(ClearClick);
            this.commandBackClick = new DelegateCommand(BackClick);
            this.commandResultClick = new DelegateCommand(ResultClick);
        }

        private bool isOperator = false;

        private double firstNumber = 0.0;
        private double secondNumber = 0.0;
        private double resultNumber = 0.0;

        private DelegateCommand commandNumClick = null;
        private DelegateCommand commandOperatorClick = null;
        private DelegateCommand commandDotClick = null;
        private DelegateCommand commandClearClick = null;
        private DelegateCommand commandBackClick = null;
        private DelegateCommand commandResultClick = null;

        public DelegateCommand CommandNumClick
        {
            get => this.commandNumClick;
            set => this.commandNumClick = value;
        }
        public DelegateCommand CommandOperatorClick
        {
            get => this.commandOperatorClick;
            set => this.commandOperatorClick = value;
        }
        public DelegateCommand CommandDotClick
        {
            get => this.commandDotClick;
            set => this.commandDotClick = value;
        }

        public DelegateCommand CommandClearClick
        {
            get => this.commandClearClick;
            set => this.commandClearClick = value;
        }
        public DelegateCommand CommandBackClick
        {
            get => this.commandBackClick;
            set => this.commandBackClick = value;
        }
        public DelegateCommand CommandResultClick
        {
            get => this.commandResultClick;
            set => this.commandResultClick = value;
        }

        private void NumClick(object obj)
        {
            string parameter = obj as string;

            if (MainViewModel.resultContentViewModel.ResultContent == "0" || isOperator)
            {
                MainViewModel.resultContentViewModel.ResultContent = parameter;
            }
            else
            {
                MainViewModel.resultContentViewModel.ResultContent += parameter;
            }

            isOperator = false;
        }

        private void OperatorClick(object obj)
        {
            string parameter = obj as string;

            if (MainViewModel.resultContentViewModel.ResultPreviewContent == null)
            {
                isOperator = true;
                double.TryParse(MainViewModel.resultContentViewModel.ResultContent, out firstNumber);
                MainViewModel.resultContentViewModel.ResultPreviewContent = MainViewModel.resultContentViewModel.ResultContent + parameter;
            }
            else
            {
                if(isOperator)
                {
                    MainViewModel.resultContentViewModel.ResultPreviewContent = MainViewModel.resultContentViewModel.ResultContent + parameter;
                }
                else
                {
                    isOperator = true;
                    double.TryParse(MainViewModel.resultContentViewModel.ResultContent, out secondNumber);
                    char lastOperator = MainViewModel.resultContentViewModel.ResultPreviewContent[MainViewModel.resultContentViewModel.ResultPreviewContent.Length - 1];
                    switch (lastOperator)
                    {
                        case '+':
                            resultNumber = firstNumber + secondNumber;
                            break;
                        case '-':
                            resultNumber = firstNumber - secondNumber;
                            break;
                        case '×':
                            resultNumber = firstNumber * secondNumber;
                            break;
                        case '÷':
                            resultNumber = firstNumber / secondNumber;
                            break;
                    }
                    MainViewModel.resultContentViewModel.ResultPreviewContent = resultNumber.ToString() + parameter;
                    MainViewModel.resultContentViewModel.ResultContent = resultNumber.ToString();
                    firstNumber = resultNumber;
                }
            }
        }
        private void DotClick(object obj)
        {
            string parameter = obj as string;

            if (MainViewModel.resultContentViewModel.ResultContent.Contains(".") == false)
            {
                MainViewModel.resultContentViewModel.ResultContent += parameter;
                isOperator = false;
            }
        }
        private void ClearClick(object obj)
        {
            MainViewModel.resultContentViewModel.ResultContent = "0";
            MainViewModel.resultContentViewModel.ResultPreviewContent = null;
            isOperator = false;
            firstNumber = 0.0;
            secondNumber = 0.0;
            resultNumber = 0.0;
        }
        private void BackClick(object obj)
        {
            string resultContent = MainViewModel.resultContentViewModel.ResultContent;

            if (MainViewModel.resultContentViewModel.ResultContent.Length > 1)
            {
                MainViewModel.resultContentViewModel.ResultContent = resultContent.Substring(0, resultContent.Length - 1);
            }
            else
            {
                MainViewModel.resultContentViewModel.ResultContent = "0";
            }
        }

        private void ResultClick(object obj)
        {
            string parameter = obj as string;

            if (MainViewModel.resultContentViewModel.ResultPreviewContent == null)
            {
                isOperator = true;
                double.TryParse(MainViewModel.resultContentViewModel.ResultContent, out firstNumber);
                MainViewModel.resultContentViewModel.ResultPreviewContent = MainViewModel.resultContentViewModel.ResultContent + parameter;
            }
            else
            {
                if (MainViewModel.resultContentViewModel.ResultPreviewContent.Contains(parameter) == false)
                {
                    isOperator = true;
                    double.TryParse(MainViewModel.resultContentViewModel.ResultContent, out secondNumber);
                    char lastOperator = MainViewModel.resultContentViewModel.ResultPreviewContent[MainViewModel.resultContentViewModel.ResultPreviewContent.Length - 1];
                    switch (lastOperator)
                    {
                        case '+':
                            resultNumber = firstNumber + secondNumber;
                            break;
                        case '-':
                            resultNumber = firstNumber - secondNumber;
                            break;
                        case '×':
                            resultNumber = firstNumber * secondNumber;
                            break;
                        case '÷':
                            resultNumber = firstNumber / secondNumber;
                            break;
                    }
                    MainViewModel.resultContentViewModel.ResultPreviewContent = firstNumber.ToString() + lastOperator + secondNumber.ToString() + parameter;
                    MainViewModel.resultContentViewModel.ResultContent = resultNumber.ToString();
                    firstNumber = resultNumber;
                }
            }
        }
    }
}
