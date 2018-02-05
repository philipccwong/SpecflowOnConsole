Feature: SpecFlowFeature1

#Issue with unable to download content when the iOS screen is not turned on
Scenario: Enable background service for iOS App ABC (For Ticket #12345)
Given I have open my iOS App ABC
When I press download data 
And The screen lock is on
Then The download should be complete next time the user login

#Issue with automatically sync not starting or stuck in 0/0
Scenario: Sync all activity when I open my iOS App ABC (For Ticket #123456)
Given I have open my iOS App ABC
When The automatic sync starts by default
Then All the data should should be sync locally on my device

#Issue with right panel content is not refreshing on folder level browsing
Scenario: Right screen panel reflects the actual content inside my iOS App ABC (For Ticket #1234567)
Given I have open my iOS App ABC and there is up-to-date content loaded
When Broswer thought contents between folders
Then The actual data should reflect and show on right side of the screen