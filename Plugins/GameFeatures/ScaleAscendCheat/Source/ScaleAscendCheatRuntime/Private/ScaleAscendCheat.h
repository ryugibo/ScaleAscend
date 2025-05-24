// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/CheatManager.h"
#include "ScaleAscendCheat.generated.h"

/**
 * 
 */
UCLASS()
class UScaleAscendCheat : public UCheatManagerExtension
{
	GENERATED_BODY()

public:
	UFUNCTION(exec)
	virtual void Hello();

};
