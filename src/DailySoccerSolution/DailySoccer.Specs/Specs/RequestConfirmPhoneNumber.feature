﻿Feature: RequestConfirmPhoneNumber
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mock
Background: Initialize
	Given Setup mocking
	And ผู้ใช้ในระบบมีดังนี้
	| Id | SecretCode | VerifiedPhoneNumber	|
	| 1  | s01        |						|
	| 2  | s02        | +66914185555		|

@mock
Scenario: ผู้ใช้ทำการขอยืนยันเบอร์โทรศัพท์ ระบบบันทึกเบอร์โทรแล้วส่งรหัสลับในการยืนยันกลับไป
	When ผู้ใช้ UserId: 's01' ขอยืนยันเบอร์โทรศัพ '0914185500'
	Then ระบบบันทึกเบอร์โทร '+66914185500' ของผู้ใช้ UserId: 's01' แล้วส่งรหัสลับในการยืนยันกลับไป

@mock
Scenario: ผู้ใช้ทำการขอยืนยันเบอร์โทรศัพท์โดยใช้เบอร์ที่มีขีด ระบบบันทึกเบอร์โทรแล้วส่งรหัสลับในการยืนยันกลับไป
	When ผู้ใช้ UserId: 's01' ขอยืนยันเบอร์โทรศัพ '091-418-5500'
	Then ระบบบันทึกเบอร์โทร '+66914185500' ของผู้ใช้ UserId: 's01' แล้วส่งรหัสลับในการยืนยันกลับไป

@mock
Scenario: ผู้ใช้ทำการขอยืนยันเบอร์โทรศัพท์แต่เป็นเบอร์ที่ไม่ถูกต้อง (สั้นกว่า 6 หลัก) ระบบไม่ทำการบันทึกเบอร์โทรและไม่ส่งรหัสลับกลับไป
	When ผู้ใช้ UserId: 's01' ขอยืนยันเบอร์โทรศัพ '12345'
	Then ระบบไม่ทำการบันทึกเบอร์โทรและไม่ส่งรหัสลับกลับไป

@mock
Scenario: ผู้ใช้ทำการขอยืนยันเบอร์โทรศัพท์แต่เป็นเบอร์ที่ไม่ถูกต้อง (ยาวกว่า 20 หลัก) ระบบไม่ทำการบันทึกเบอร์โทรและไม่ส่งรหัสลับกลับไป
	When ผู้ใช้ UserId: 's01' ขอยืนยันเบอร์โทรศัพ '012345678901234567890'
	Then ระบบไม่ทำการบันทึกเบอร์โทรและไม่ส่งรหัสลับกลับไป

@mock
Scenario: ผู้ใช้ที่เคยยืนยันเบอร์โทรเสร็จสมบูรณ์ไปแล้วขอทำการยืนยันเบอร์โทรอีกครั้ง ระบบไม่ทำการบันทึกเบอร์โทรและไม่ส่งรหัสลับกลับไป
	When ผู้ใช้ UserId: 's02' ขอยืนยันเบอร์โทรศัพ '0914185500'
	Then ระบบไม่ทำการบันทึกเบอร์โทรและไม่ส่งรหัสลับกลับไป

@mock
Scenario: ผู้ใช้ที่ไม่มีในระบบขอยืนยันเบอร์โทรศัพ ระบบไม่ทำการบันทึกเบอร์โทรและไม่ส่งรหัสลับกลับไป
	When ผู้ใช้ UserId: 'unknow' ขอยืนยันเบอร์โทรศัพ '0914185500'
	Then ระบบไม่ทำการบันทึกเบอร์โทรและไม่ส่งรหัสลับกลับไป