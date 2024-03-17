Feature: Начальный тест для изучения Cucumber
	Описание данной featute

	Scenario: Простой тест без тела

	Scenario: Простой тест с Given
		Given открыт браузер 

	Scenario: Простой тест с Given и When
		Given открыт браузер 
		When страница логина открыта

	Scenario: Простой тест с Given и Then
		Given открыт браузер
		Then username field is displayed

	Scenario: Простой тест с двумя Given
		Given открыт браузер
		Given страница логина открыта
		
	Scenario: Простой тест со всеми ключевыми фразами
		Given открыт браузер
		When страница логина открыта
		Then username field is displayed