package com.softuni.controller;

import com.softuni.entity.Calculator;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class HomeController {
	@GetMapping("/")
	public String index(Model model) {
		model.addAttribute("operator", "+");
		model.addAttribute("view", "views/calculatorForm");
		return "base-layout";
	}
	@PostMapping("/")
	public String indexAction(@RequestParam String leftOperand,
					   @RequestParam String operator,
					   @RequestParam String rightOperand,
					   Model model){
		double number1;
		double number2;

		try{
			number1 = Double.parseDouble(leftOperand);
		} catch (NumberFormatException ex){
			number1 = 0;
		}
		try{
			number2 = Double.parseDouble(rightOperand);
		} catch (NumberFormatException ex){
			number2 = 0;
		}
		Calculator calculator = new Calculator(number1, operator,number2);
		double result = calculator.calculateResult();

		model.addAttribute("view", "views/calculatorForm");
		model.addAttribute("leftOperand", calculator.getLeftOperand());
		model.addAttribute("operator", calculator.getOperator());
		model.addAttribute("rightOperand", calculator.getRightOperand());
		model.addAttribute("result", String.format("%.2f", result));

		return "base-layout";
	}
}
