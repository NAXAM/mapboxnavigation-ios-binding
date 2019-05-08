#!/bin/bash

BUILDPATH="Carthage/Build/iOS"
OUTPUTPATH="frameworks/"
FRAMEWORKS=("MapboxCoreNavigation.framework" "MapboxSpeech.framework" "MapboxDirections.framework" "Polyline.framework" "MapboxMobileEvents.framework" "Solar.framework" "MapboxNavigation.framework" "Turf.framework")

for FRAMEWORK in "${FRAMEWORKS[@]}"; do
	FRAMEWORKPATH="${BUILDPATH}/${FRAMEWORK}"
	echo "Copying ${FRAMEWORK} from: ${FRAMEWORKPATH} to: ${OUTPUTPATH}"
	
	if [ -d "${FRAMEWORKPATH}" ];
	then
		echo "+ cp -R ${FRAMEWORKPATH} ${OUTPUTPATH}"
		cp -R "${FRAMEWORKPATH}" "${OUTPUTPATH}"
	fi
	
	if [ -f "${FRAMEWORKPATH}" ];
	then
		echo "+ cp ${FRAMEWORKPATH} ${OUTPUTPATH}"
		cp "${FRAMEWORKPATH}" "${OUTPUTPATH}"
	fi
done