# Demo Prompts

## Generative AI

### Prompt

```
Create an Adaptive Card using valid 1.5 Schema for a visually interesting medium sized Windows 11 Widget with emoji based on the following contents "Describe using Generative AI to create Windows Widgets" do not include any images and do not return any non-JSON text or numbering or ```json``` markdown
```

### Output

```json
{
  "$schema": "http://adaptivecards.io/schemas/adaptive-card.json",
  "type": "AdaptiveCard",
  "version": "1.5",
  "body": [
    {
      "type": "TextBlock",
      "text": "🤖 Using Generative AI to create Windows Widgets.",
      "weight": "Bolder",
      "size": "Medium",
      "wrap": true
    },
    {
      "type": "TextBlock",
      "text": "✨ Generative AI can design interactive Windows Widgets",
      "wrap": true
    },
    {
      "type": "TextBlock",
      "text": "⚡ Efficiency: Quickly generate tailored widgets.",
      "wrap": true
    },
    {
      "type": "TextBlock",
      "text": "🎨 Customization: Easily adapt to user preferences.",
      "wrap": true
    },
    {
      "type": "TextBlock",
      "text": "🌟 Innovation: Introduce new and engaging functionalities.",
      "wrap": true
    }
  ],
  "actions": [
    {
      "type": "Action.OpenUrl",
      "title": "Learn More",
      "url": "https://docs.microsoft.com/en-us/windows/apps/desktop/modernize/widgets-create"
    }
  ]
}
```

## Microsoft MVP

### Prompt

```
Create an Adaptive Card using valid 1.5 Schema for a visually interesting medium sized Windows 11 Widget with emoji based on the following contents "Describe Microsoft MVP Award and include colourful text with RichTextBlock" do not include any images and do not return any non-JSON text or numbering or ```json``` markdown
```

### Output

```json
{
  "$schema": "http://adaptivecards.io/schemas/adaptive-card.json",
  "version": "1.5",
  "type": "AdaptiveCard",
  "body": [
    {
      "type": "RichTextBlock",
      "inlines": [
        {
          "type": "TextRun",
          "text": "🏆 Microsoft MVP Award 🏆",
          "color": "Accent",
          "weight": "Bolder",
          "size": "Medium"
        },
        {
          "type": "TextRun",
          "text": "\n\nThe Microsoft MVP Award is a prestigious recognition for exceptional community leaders. These individuals passionately share their technical expertise and real-world knowledge. 🌟",
          "color": "Good",
          "size": "Small"
        },
        {
          "type": "TextRun",
          "text": "\n\nAwardees contribute significantly to the tech community, providing guidance, support, and encouragement. 🤝",
          "color": "Attention",
          "size": "Small"
        },
        {
          "type": "TextRun",
          "text": "\n\nMVPs enjoy exclusive benefits, including early access to Microsoft products, direct communication with product teams, and invitations to special events. 🎉",
          "color": "Warning",
          "size": "Small"
        },
        {
          "type": "TextRun",
          "text": "\n\nDiscover more about the MVP Award and how to get involved! 📚",
          "color": "Accent",
          "italic": true,
          "size": "Small"
        }
      ]
    }
  ]
}
```

## Background Image

### Prompt

```
Create an Adaptive Card using valid 1.5 Schema for a visually interesting medium sized Windows 11 Widget with emoji based on the following contents "Talk About Adaptive Cards and include an appropriate BackgroundImage that exists" do not include any images and do not return any non-JSON text or numbering or json
 ```

 ### Output

 ```json
{
  "$schema": "http://adaptivecards.io/schemas/adaptive-card.json",
  "version": "1.5",
  "type": "AdaptiveCard",
  "backgroundImage": {
    "url": "https://adaptivecards.io/content/AlkiBeach.jpg",
    "fillMode": "Cover"
  },
  "body": [
    {
      "type": "TextBlock",
      "text": "💬 Let's Talk About Adaptive Cards!",
      "size": "Medium",
      "weight": "Bolder",
      "horizontalAlignment": "Center",
      "wrap": true,
      "color": "Light"
    },
    {
      "type": "TextBlock",
      "text": "🧩 Adaptive Cards enable you to design flexible, interactive content seamlessly.",
      "wrap": true,
      "spacing": "Medium",
      "color": "Light"
    },
    {
      "type": "TextBlock",
      "text": "✨ Easily create responsive and dynamic UI experiences!",
      "wrap": true,
      "spacing": "Small",
      "isSubtle": true,
      "color": "Light"
    }
  ]
}
 ```

## Toggle Visiblity

### Prompt

```
Create an Adaptive Card using valid 1.5 Schema for a visually interesting medium sized Windows 11 Widget that has a paragraph about Windows Widgets where the visiblity of the paragraph is toggled with a button called Toggle do not include any images and do not return any non-JSON text or numbering or ```json``` markdown
```

### Output

```json
{
  "$schema": "http://adaptivecards.io/schemas/adaptive-card.json",
  "type": "AdaptiveCard",
  "version": "1.5",
  "body": [
    {
      "type": "TextBlock",
      "text": "Windows Widgets",
      "weight": "Bolder",
      "size": "Medium",
      "wrap": true
    },
    {
      "type": "Container",
      "items": [
        {
          "type": "TextBlock",
          "text": "Windows Widgets are small, interactive applications that provide easy access to information and functionality from your desktop.",
          "wrap": true,
          "id": "widgetDescription",
          "isVisible": false
        }
      ]
    }
  ],
  "actions": [
    {
      "type": "Action.ToggleVisibility",
      "title": "Toggle",
      "targetElements": [
        "widgetDescription"
      ]
    }
  ]
}
```

### Countdown Widget

```
Create an Adaptive Card using valid 1.5 Schema for a visually interesting medium sized Windows 11 Widget that uses as many Schema elements as possible for a Countdown Widget and do not include any images and do not return any non-JSON text or numbering or ```json``` markdown
```

```json
{
  "$schema": "http://adaptivecards.io/schemas/adaptive-card.json",
  "type": "AdaptiveCard",
  "version": "1.5",
  "body": [
    {
      "type": "TextBlock",
      "text": "⏳ Countdown",
      "weight": "Bolder",
      "size": "Medium",
      "wrap": true
    },
    {
      "type": "ColumnSet",
      "columns": [
        {
          "type": "Column",
          "items": [
            {
              "type": "Input.Date",
              "id": "endDate",
              "label": "Date"
            }
          ],
          "width": "auto"
        },
        {
          "type": "Column",
          "items": [
            {
              "type": "Input.Time",
              "id": "endTime",
              "label": "Time"
            }
          ],
          "width": "auto"
        }
      ]
    },
    {
      "type": "TextBlock",
      "text": "Days: ${days}",
      "wrap": true
    },
    {
      "type": "TextBlock",
      "text": "Hours: ${hours}",
      "wrap": true
    },
    {
      "type": "TextBlock",
      "text": "Minutes: ${minutes}",
      "wrap": true
    },
    {
      "type": "ActionSet",
      "actions": [
        {
          "type": "Action.Submit",
          "title": "Start"
        }
      ]
    }
  ]
}

```

## Cat Facts

### Prompt

```
Create an Adaptive Card using valid 1.5 Schema for a visually interesting Windows 11 Widget with emoji with a single Submit action called Refresh that uses Databinding with a dollar sign for fields using only fields from this API endpoint https://catfact.ninja/fact that returns this data ```json {"fact":"Most cats adore sardines.","length":25}``` do not return any non-JSON text or numbering or ```json``` markdown
```

### Output

```json
{
  "$schema": "http://adaptivecards.io/schemas/adaptive-card.json",
  "version": "1.5",
  "type": "AdaptiveCard",
  "body": [
    {
      "type": "TextBlock",
      "text": "🐱 Cat Fact of the Day",
      "size": "Large",
      "weight": "Bolder",
      "horizontalAlignment": "Center"
    },
    {
      "type": "TextBlock",
      "text": "${fact}",
      "wrap": true,
      "spacing": "Medium"
    },
    {
      "type": "TextBlock",
      "text": "💡 Length: ${length} characters",
      "spacing": "Small",
      "isSubtle": true
    }
  ],
  "actions": [
    {
      "type": "Action.Submit",
      "title": "🔄 Refresh"
    }
  ]
}
```

### Data

```json
{"fact":"Most cats adore sardines.","length":25}
```

### Endpoint

```
https://catfact.ninja/fact
````