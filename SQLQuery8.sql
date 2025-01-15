SELECT Applications.ApplicationID, 
	   Applications.ApplicantPersonID, 
	   Applications.ApplicationStatus, 
	   LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, 
	   LocalDrivingLicenseApplications.ApplicationID,
	   LocalDrivingLicenseApplications.LicenseClassID FROM 
	   Applications 
INNER JOIN 
	   LocalDrivingLicenseApplications 
ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
WHERE ApplicantPersonID = 1025 and ApplicationStatus = 1 and LicenseClassID = 3;



SELECT * FROM LocalDrivingLicenseApplications

SELECT * FROM LocalDrivingLicenseApplications_View where NationalNo = 'n4'

select * from Applications where ApplicantPersonID = 1025

SELECT * FROM Tests where TestAppointmentID = 109 and TestResult = 1;


-- Count Passed Test
SELECT Count(*) as PassedTests , LocalDrivingLicenseApplicationID From (
SELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, TestAppointments.TestAppointmentID, Tests.TestID, Tests.TestResult
FROM TestAppointments 
INNER JOIN LocalDrivingLicenseApplications 
ON 
	  TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
INNER JOIN Tests 
ON 
	TestAppointments.TestAppointmentID = Tests.TestAppointmentID
	WHERE TestResult  = 1
	) as R1
Group BY LocalDrivingLicenseApplicationID
Having R1.LocalDrivingLicenseApplicationID = 38



SELECT * FROM TestAppointments
WHere LocalDrivingLicenseApplicationID = 36 and TestTypeID = 1 and IsLocked = 0

SELECT TestAppointments.TestAppointmentID, TestAppointments.AppointmentDate, TestAppointments.PaidFees, TestAppointments.IsLocked FROM TestAppointments
WHERE TestAppointments.LocalDrivingLicenseApplicationID = 39 and TestAppointments.TestTypeID = 3 


SELECT * FROM TestAppointments WHERE TestAppointmentID = 116

SELECT * FROM TestAppointments WHERE TestAppointmentID = 108


SELECT * FROM TestAppointments WHERE TestAppointmentID = 128


-- COUNT Failed Tests
SELECT COUNT(*) as TestTrail, LocalDrivingLicenseApplicationID FROM
(
SELECT TestAppointments.TestAppointmentID, LocalDrivingLicenseApplicationID, TestTypeID, TestID, TestResult From TestAppointments
INNER JOIN Tests on TestAppointments.TestAppointmentID = Tests.TestAppointmentID
WHERE TestAppointments.LocalDrivingLicenseApplicationID = 36 and TestTypeID = 1 and TestResult = 0
) as R1
GROUP BY LocalDrivingLicenseApplicationID


SELECT * FROM Tests WHERE TestAppointmentID = 108 and TestResult = 1;



SELECT TOP(2) * FROM Applications

SELECT * FROM LocalDrivingLicenseApplications where ApplicationID = 110

SELECT * FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = 36

SELECT * FROM Tests WHERE TestAppointmentID IN (108, 109, 110, 111, 112);



-- Return True IF Test Failed
SELECT TestFail = 1 FROM TestAppointments INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
WHERE LocalDrivingLicenseApplicationID = 45 and TestTypeID = 1 and TestResult = 0;


-- Check IF Test Passed
SELECT TestAppointments.TestAppointmentID, LocalDrivingLicenseApplicationID, TestTypeID, TestResult FROM TestAppointments INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
WHERE LocalDrivingLicenseApplicationID = 45 and TestTypeID = 1 and TestResult = 1;

-- Get Retake Application info
SELECT * FROM LocalDrivingLicenseApplications Where LocalDrivingLicenseApplicationID = 45


select * from TestAppointments where TestAppointmentID = 129

SELECT * FROM Applications where ApplicationID = 119

SELECT * FROM Tests Where TestAppointmentID = 129



SELECT * FROM LocalDrivingLicenseApplications_View

SELECT * FROM LocalDrivingLicenseFullApplications_View



SELECT  Drivers.DriverID
FROM Applications INNER JOIN LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID 
				  INNER JOIN People ON Applications.ApplicantPersonID = People.PersonID 
				  INNER JOIN Drivers ON People.PersonID = Drivers.PersonID
Where LocalDrivingLicenseApplicationID = 36

SELECT Applications.*, LicenseClassID FROM Applications INNER JOIN LocalDrivingLicenseApplications
ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
WHERE Applications.ApplicantPersonID = 1029 and LicenseClassID = 3 and ApplicationStatus = 3

SELECT * FROM Licenses where ApplicationID = 119

SELECT LicenseID, ApplicationID, LicenseClasses.ClassName, IssueDate, ExpirationDate, IsActive FROM Licenses
INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
WHERE Drivers.PersonID = 1029

SELECT  * from drivers where PersonID = 1029

SELECT * FROM InternationalLicenses

SELECT InternationalLicenseID, InternationalLicenses.ApplicationID, IssuedUsingLocalLicenseID as [Local License ID], InternationalLicenses.IssueDate, InternationalLicenses.ExpirationDate, InternationalLicenses.IsActive FROM InternationalLicenses
INNER JOIN Licenses ON InternationalLicenses.IssuedUsingLocalLicenseID = Licenses.LicenseID
INNER JOIN Drivers ON InternationalLicenses.DriverID = Drivers.DriverID
WHERE Drivers.PersonID = 1029

SELECT InternationalLicenseID as [Int.License ID], ApplicationID, DriverID, IssuedUsingLocalLicenseID as [L.License ID], IssueDate, ExpirationDate, IsActive FROM InternationalLicenses


SELECT * from Applications

SELECT * from Licenses where LicenseID = 25


SELECT LicenseID FROM Licenses INNER JOIN LocalDrivingLicenseApplications ON Licenses.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = 39

SELECT * FROM DetainedLicenses Where LicenseID = 27 and IsReleased = 0
 
SELECT * FROM DetainedLicenses_View

SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, 
CASE
 WHEN Gendor = 0 then 'MALE'
 WHEN Gendor = 1 then 'FEMALE'
END as Gendor, People.Address, Phone, Email, Countries.CountryName, ImagePath
FROM People INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID
ORDER BY FirstName

SELECT * FROM Users

SELECT UserID as [USER ID], Users.PersonID as [Person ID], [FULL NAME] = FirstName + ' ' + SecondName + ' ' + ISNULL(ThirdName,'') + ' ' + LastName, UserName as [User_Name], IsActive as [Is Active] from Users
INNER JOIN People ON Users.PersonID = People.PersonID;